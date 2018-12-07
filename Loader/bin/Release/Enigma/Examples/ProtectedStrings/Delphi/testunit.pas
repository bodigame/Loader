unit testunit;

interface

uses
  Windows, Messages, SysUtils, Variants, Classes, Graphics, Controls, Forms,
  Dialogs, StdCtrls;

type
  TForm1 = class(TForm)
    Label1: TLabel;
    Edit1: TEdit;
    Label2: TLabel;
    Edit2: TEdit;
    Label3: TLabel;
    Edit3: TEdit;
    Button1: TButton;
    procedure Button1Click(Sender: TObject);
    procedure FormShow(Sender: TObject);
  private
    { Private declarations }
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

uses enigma_ide;

{$R *.dfm}

procedure TForm1.Button1Click(Sender: TObject);
begin
  Close;
end;

procedure TForm1.FormShow(Sender: TObject);
begin
  // Extract protected ansi string using key
  Edit1.Text := EP_ProtectedStringAsAnsiStringByKey('fyi6z02Y');
  // Extract protected ansi string using id
  Edit2.Text := EP_ProtectedStringAsAnsiStringByID(1);
  // Extract protected wide string using key
  Edit3.Text := EP_ProtectedStringAsWideStringByKey('26Lu66Er');
end;

end.
