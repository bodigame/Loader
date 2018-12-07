// testDlg.cpp : implementation file
//

#include "stdafx.h"
#include "test.h"
#include "testDlg.h"

#include "../../../EnigmaSDK/VC/enigma_ide.h"
#pragma comment (lib,"../../../EnigmaSDK/VC/enigma_ide.lib")

#ifdef _DEBUG
#define new DEBUG_NEW
#undef THIS_FILE
static char THIS_FILE[] = __FILE__;
#endif

/////////////////////////////////////////////////////////////////////////////
// CTestDlg dialog
 

CTestDlg::CTestDlg(CWnd* pParent /*=NULL*/)
	: CDialog(CTestDlg::IDD, pParent)
{
	//{{AFX_DATA_INIT(CTestDlg)
		// NOTE: the ClassWizard will add member initialization here
	//}}AFX_DATA_INIT
	// Note that LoadIcon does not require a subsequent DestroyIcon in Win32
	m_hIcon = AfxGetApp()->LoadIcon(IDR_MAINFRAME);
}

void CTestDlg::DoDataExchange(CDataExchange* pDX)
{
	CDialog::DoDataExchange(pDX);
	//{{AFX_DATA_MAP(CTestDlg)
		// NOTE: the ClassWizard will add DDX and DDV calls here
	//}}AFX_DATA_MAP
}

BEGIN_MESSAGE_MAP(CTestDlg, CDialog)
	//{{AFX_MSG_MAP(CTestDlg)
	ON_WM_PAINT()
	ON_WM_QUERYDRAGICON()
	ON_BN_CLICKED(IDC_BUTTON_CLOSE, OnButtonClose)
	//}}AFX_MSG_MAP
	ON_BN_CLICKED(IDC_BUTTON_REGISTER, &CTestDlg::OnBnClickedButtonRegister)
END_MESSAGE_MAP()

/////////////////////////////////////////////////////////////////////////////
// CTestDlg message handlers

BOOL CTestDlg::OnInitDialog()
{
	CDialog::OnInitDialog();

	// Set the icon for this dialog.  The framework does this automatically
	//  when the application's main window is not a dialog
	SetIcon(m_hIcon, TRUE);			// Set big icon
	SetIcon(m_hIcon, FALSE);		// Set small icon
	
	// TODO: Add extra initialization here
	
	return TRUE;  // return TRUE  unless you set the focus to a control
}

// If you add a minimize button to your dialog, you will need the code below
//  to draw the icon.  For MFC applications using the document/view model,
//  this is automatically done for you by the framework.

void CTestDlg::OnPaint() 
{
	if (IsIconic())
	{
		CPaintDC dc(this); // device context for painting

		SendMessage(WM_ICONERASEBKGND, (WPARAM) dc.GetSafeHdc(), 0);

		// Center icon in client rectangle
		int cxIcon = GetSystemMetrics(SM_CXICON);
		int cyIcon = GetSystemMetrics(SM_CYICON);
		CRect rect;
		GetClientRect(&rect);
		int x = (rect.Width() - cxIcon + 1) / 2;
		int y = (rect.Height() - cyIcon + 1) / 2;

		// Draw the icon
		dc.DrawIcon(x, y, m_hIcon);
	}
	else
	{
		CDialog::OnPaint();
	}
}

// The system calls this to obtain the cursor to display while the user drags
//  the minimized window.
HCURSOR CTestDlg::OnQueryDragIcon()
{
	return (HCURSOR) m_hIcon;
}

void CTestDlg::OnButtonClose() 
{
	// TODO: Add your control notification handler code here
	ExitProcess(0);
}
void CTestDlg::OnBnClickedButtonRegister()
{
	// TODO: Add your control notification handler code here
	char name[255];
	int namelen = GetDlgItemText(IDC_EDIT_USERINFO, (char*)&name, sizeof(name));
	char key[2048];
	int keylen = GetDlgItemText(IDC_EDIT_KEY, (char*)&key, sizeof(key));

    TKeyInformation ki;
    memset(&ki, 0, sizeof(ki));

    if (EP_RegKeyInformation((char*)&name, (char*)&key, &ki))
    {	  
		char tmp[255];
		// Creation date	  
		char mes[2048] = "Registration Information is valid and contains the following information:";	  
		sprintf(tmp, "\nCreation date: %d/%d/%d", ki.CreationYear, ki.CreationMonth, ki.CreationDay);
		strcat(mes, tmp);
        if (ki.UseKeyExpiration)
        {
			sprintf(tmp, "\nExpiration date: %d/%d/%d", ki.ExpirationYear, ki.ExpirationMonth, ki.ExpirationDay);
			strcat(mes, tmp);
        }
        if (ki.UseHardwareLocking)
        {
			strcat(mes, "\nKey is Hardware Locked");
        }
        if (ki.UseExecutionsLimit)
        {
			sprintf(tmp, "\nExecutions number: %d", ki.ExecutionsCount);
			strcat(mes, tmp);
        }
        if (ki.UseDaysLimit)
        {
			sprintf(tmp, "\nDays number: %d", ki.DaysCount);
			strcat(mes, tmp);
        }
        if (ki.UseRunTimeLimit)
        {
			sprintf(tmp, "\nRun-time minutes: %d", ki.RunTimeMinutes);
			strcat(mes, tmp);
        }
        if (ki.UseGlobalTimeLimit)
        {
			sprintf(tmp, "\nGlobal time minutes: %d", ki.GlobalTimeMinutes);
			strcat(mes, tmp);
        }
        if (ki.UseCountyLimit)
        {
            for (int i = 0; i < ARRAYSIZE(KEY_COUNTRIES); i++)
            {
                if (ki.CountryCode == KEY_COUNTRIES[i].Code)
                {
					sprintf(tmp, "\nCountry Lock: %s", KEY_COUNTRIES[i].Name);
					strcat(mes, tmp);
                    break;
                }
            }
        }
        if (ki.UseRegisterAfter)
        {
			sprintf(tmp, "\nRegister After date: %d/%d/%d", ki.RegisterAfterYear, ki.RegisterAfterMonth, ki.RegisterAfterDay);
			strcat(mes, tmp);
        }
        if (ki.UseRegisterBefore)
        {
			sprintf(tmp, "\nRegister Before date: %d/%d/%d", ki.RegisterBeforeYear, ki.RegisterBeforeMonth, ki.RegisterBeforeDay);
			strcat(mes, tmp);
        }
        for (int i = 0; i < NUMBER_OF_CRYPTED_SECTIONS; i++)
        {
            if (ki.EncryptedSections[i])
            {
				sprintf(tmp, "\nLocked section #%d", i + 1);
				strcat(mes, tmp);
            }
        }
		MessageBox((char*)&mes, "Information", MB_OK | MB_ICONINFORMATION);
    } else
    {
		MessageBox("Registration Information is invalid", "Error", MB_OK | MB_ICONERROR);
    }

}
