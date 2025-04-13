using System;
using WixSharp;

namespace ilfortunedinumerone_setup
{
    internal class Program
    {
        static void Main()
        {
            Project project = new Project("Il fortune di numerone",
                              new Dir(@"[ProgramFiles64Folder]\\numfortune2",
                                  new DirFiles(@"*.*"),
                                  new Dir("runtimes",
                                      new Dir("win-x64",
                                            new Dir("native",
                                                new File("runtimes\\win-x64\\native\\libHarfBuzzSharp.dll"),
                                                new File("runtimes\\win-x64\\native\\libSkiaSharp.dll")
                                            )
                                        )
                                    )
                        ),
                        new Dir(@"%ProgramMenu%",
                         new ExeFileShortcut("Il fortune di numerone", "[ProgramFiles64Folder]\\numfortune2\\numfortune2.Desktop.exe", "") { WorkingDirectory = "[INSTALLDIR]" }
                      )//,
                       //new Property("ALLUSERS","0")
            );

            project.GUID = new Guid("C4FEB52B-82C3-4E05-967F-4484633EA105");
            project.Version = new Version("1.0.0.1");
            project.Platform = Platform.x64;
            project.SourceBaseDir = "F:\\source\\numfortune2\\numfortune2.Desktop\\bin\\Release\\net9.0-windows10.0.26100.0";
            project.LicenceFile = "MIT.rtf";
            project.OutDir = "F:\\";
            project.ControlPanelInfo.Manufacturer = "Giulio Sorrentino";
            project.ControlPanelInfo.Name = "il fortune in avalonia e coi cookie italiani";
            project.ControlPanelInfo.HelpLink = "https://giulianospaghetti.altervista.org";
            project.Description = "Un semplice fortune teller coi cookie italiani per windows 10 e 11";
            //            project.Properties.SetValue("ALLUSERS", 0);
            project.BuildMsi();
        }
    }
}
