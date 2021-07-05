namespace CodeDeflautBox
{
    class RunProgram
    {
        public RunProgram(char mode, int id)
        {
            switch (mode)
            {
                case 'S':
                    switch (id)
                    {
                        case 1:
                            HelloWorld hw = new HelloWorld(mode);
                            break;
                        case 2:
                        case 3:
                            OperatorVar ov = new OperatorVar(mode);
                            break;
                        case 4:
                            SetVar sv = new SetVar(mode);
                            break;
                            //...
                    }
                    break;
                case 'M':
                    switch (id)
                    {
                        case 1:
                            HelloWorld hw = new HelloWorld(mode);
                            break;
                        case 2:
                            ShowMessageBox sm = new ShowMessageBox();
                            break;
                        case 3:
                            OperatorVar ov = new OperatorVar(mode);
                            break;
                        case 4:
                            SetVar sv = new SetVar(mode);
                            break;
                    }
                    break;
                case 'W':
                    switch (id)
                    {

                    }
                    break;
            }
        }
    }
}
