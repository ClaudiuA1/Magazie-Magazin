﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name Nume from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/adaugaMagazie", ReplyAction="*")]
        WindowsFormsApp1.ServiceReference1.adaugaMagazieResponse adaugaMagazie(WindowsFormsApp1.ServiceReference1.adaugaMagazieRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/adaugaMagazie", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.adaugaMagazieResponse> adaugaMagazieAsync(WindowsFormsApp1.ServiceReference1.adaugaMagazieRequest request);
        
        // CODEGEN: Generating message contract since element name NumeProdus from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateMagazie", ReplyAction="*")]
        WindowsFormsApp1.ServiceReference1.updateMagazieResponse updateMagazie(WindowsFormsApp1.ServiceReference1.updateMagazieRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateMagazie", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.updateMagazieResponse> updateMagazieAsync(WindowsFormsApp1.ServiceReference1.updateMagazieRequest request);
        
        // CODEGEN: Generating message contract since element name stergeMagazieResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/stergeMagazie", ReplyAction="*")]
        WindowsFormsApp1.ServiceReference1.stergeMagazieResponse stergeMagazie(WindowsFormsApp1.ServiceReference1.stergeMagazieRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/stergeMagazie", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.stergeMagazieResponse> stergeMagazieAsync(WindowsFormsApp1.ServiceReference1.stergeMagazieRequest request);
        
        // CODEGEN: Generating message contract since element name NumeProdus from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/plaseazaComanda", ReplyAction="*")]
        WindowsFormsApp1.ServiceReference1.plaseazaComandaResponse plaseazaComanda(WindowsFormsApp1.ServiceReference1.plaseazaComandaRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/plaseazaComanda", ReplyAction="*")]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.plaseazaComandaResponse> plaseazaComandaAsync(WindowsFormsApp1.ServiceReference1.plaseazaComandaRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class adaugaMagazieRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="adaugaMagazie", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.adaugaMagazieRequestBody Body;
        
        public adaugaMagazieRequest() {
        }
        
        public adaugaMagazieRequest(WindowsFormsApp1.ServiceReference1.adaugaMagazieRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class adaugaMagazieRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Nume;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Cantitate;
        
        public adaugaMagazieRequestBody() {
        }
        
        public adaugaMagazieRequestBody(string Nume, int Cantitate) {
            this.Nume = Nume;
            this.Cantitate = Cantitate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class adaugaMagazieResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="adaugaMagazieResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.adaugaMagazieResponseBody Body;
        
        public adaugaMagazieResponse() {
        }
        
        public adaugaMagazieResponse(WindowsFormsApp1.ServiceReference1.adaugaMagazieResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class adaugaMagazieResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string adaugaMagazieResult;
        
        public adaugaMagazieResponseBody() {
        }
        
        public adaugaMagazieResponseBody(string adaugaMagazieResult) {
            this.adaugaMagazieResult = adaugaMagazieResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateMagazieRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateMagazie", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.updateMagazieRequestBody Body;
        
        public updateMagazieRequest() {
        }
        
        public updateMagazieRequest(WindowsFormsApp1.ServiceReference1.updateMagazieRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class updateMagazieRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NumeProdus;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Cantitate;
        
        public updateMagazieRequestBody() {
        }
        
        public updateMagazieRequestBody(string NumeProdus, int Cantitate) {
            this.NumeProdus = NumeProdus;
            this.Cantitate = Cantitate;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class updateMagazieResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="updateMagazieResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.updateMagazieResponseBody Body;
        
        public updateMagazieResponse() {
        }
        
        public updateMagazieResponse(WindowsFormsApp1.ServiceReference1.updateMagazieResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class updateMagazieResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string updateMagazieResult;
        
        public updateMagazieResponseBody() {
        }
        
        public updateMagazieResponseBody(string updateMagazieResult) {
            this.updateMagazieResult = updateMagazieResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class stergeMagazieRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="stergeMagazie", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.stergeMagazieRequestBody Body;
        
        public stergeMagazieRequest() {
        }
        
        public stergeMagazieRequest(WindowsFormsApp1.ServiceReference1.stergeMagazieRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class stergeMagazieRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ProdusId;
        
        public stergeMagazieRequestBody() {
        }
        
        public stergeMagazieRequestBody(int ProdusId) {
            this.ProdusId = ProdusId;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class stergeMagazieResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="stergeMagazieResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.stergeMagazieResponseBody Body;
        
        public stergeMagazieResponse() {
        }
        
        public stergeMagazieResponse(WindowsFormsApp1.ServiceReference1.stergeMagazieResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class stergeMagazieResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string stergeMagazieResult;
        
        public stergeMagazieResponseBody() {
        }
        
        public stergeMagazieResponseBody(string stergeMagazieResult) {
            this.stergeMagazieResult = stergeMagazieResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class plaseazaComandaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="plaseazaComanda", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.plaseazaComandaRequestBody Body;
        
        public plaseazaComandaRequest() {
        }
        
        public plaseazaComandaRequest(WindowsFormsApp1.ServiceReference1.plaseazaComandaRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class plaseazaComandaRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string NumeProdus;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int Bucati;
        
        public plaseazaComandaRequestBody() {
        }
        
        public plaseazaComandaRequestBody(string NumeProdus, int Bucati) {
            this.NumeProdus = NumeProdus;
            this.Bucati = Bucati;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class plaseazaComandaResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="plaseazaComandaResponse", Namespace="http://tempuri.org/", Order=0)]
        public WindowsFormsApp1.ServiceReference1.plaseazaComandaResponseBody Body;
        
        public plaseazaComandaResponse() {
        }
        
        public plaseazaComandaResponse(WindowsFormsApp1.ServiceReference1.plaseazaComandaResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class plaseazaComandaResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string plaseazaComandaResult;
        
        public plaseazaComandaResponseBody() {
        }
        
        public plaseazaComandaResponseBody(string plaseazaComandaResult) {
            this.plaseazaComandaResult = plaseazaComandaResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WindowsFormsApp1.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WindowsFormsApp1.ServiceReference1.WebService1Soap>, WindowsFormsApp1.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.ServiceReference1.adaugaMagazieResponse WindowsFormsApp1.ServiceReference1.WebService1Soap.adaugaMagazie(WindowsFormsApp1.ServiceReference1.adaugaMagazieRequest request) {
            return base.Channel.adaugaMagazie(request);
        }
        
        public string adaugaMagazie(string Nume, int Cantitate) {
            WindowsFormsApp1.ServiceReference1.adaugaMagazieRequest inValue = new WindowsFormsApp1.ServiceReference1.adaugaMagazieRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.adaugaMagazieRequestBody();
            inValue.Body.Nume = Nume;
            inValue.Body.Cantitate = Cantitate;
            WindowsFormsApp1.ServiceReference1.adaugaMagazieResponse retVal = ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).adaugaMagazie(inValue);
            return retVal.Body.adaugaMagazieResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.adaugaMagazieResponse> WindowsFormsApp1.ServiceReference1.WebService1Soap.adaugaMagazieAsync(WindowsFormsApp1.ServiceReference1.adaugaMagazieRequest request) {
            return base.Channel.adaugaMagazieAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.adaugaMagazieResponse> adaugaMagazieAsync(string Nume, int Cantitate) {
            WindowsFormsApp1.ServiceReference1.adaugaMagazieRequest inValue = new WindowsFormsApp1.ServiceReference1.adaugaMagazieRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.adaugaMagazieRequestBody();
            inValue.Body.Nume = Nume;
            inValue.Body.Cantitate = Cantitate;
            return ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).adaugaMagazieAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.ServiceReference1.updateMagazieResponse WindowsFormsApp1.ServiceReference1.WebService1Soap.updateMagazie(WindowsFormsApp1.ServiceReference1.updateMagazieRequest request) {
            return base.Channel.updateMagazie(request);
        }
        
        public string updateMagazie(string NumeProdus, int Cantitate) {
            WindowsFormsApp1.ServiceReference1.updateMagazieRequest inValue = new WindowsFormsApp1.ServiceReference1.updateMagazieRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.updateMagazieRequestBody();
            inValue.Body.NumeProdus = NumeProdus;
            inValue.Body.Cantitate = Cantitate;
            WindowsFormsApp1.ServiceReference1.updateMagazieResponse retVal = ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).updateMagazie(inValue);
            return retVal.Body.updateMagazieResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.updateMagazieResponse> WindowsFormsApp1.ServiceReference1.WebService1Soap.updateMagazieAsync(WindowsFormsApp1.ServiceReference1.updateMagazieRequest request) {
            return base.Channel.updateMagazieAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.updateMagazieResponse> updateMagazieAsync(string NumeProdus, int Cantitate) {
            WindowsFormsApp1.ServiceReference1.updateMagazieRequest inValue = new WindowsFormsApp1.ServiceReference1.updateMagazieRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.updateMagazieRequestBody();
            inValue.Body.NumeProdus = NumeProdus;
            inValue.Body.Cantitate = Cantitate;
            return ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).updateMagazieAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.ServiceReference1.stergeMagazieResponse WindowsFormsApp1.ServiceReference1.WebService1Soap.stergeMagazie(WindowsFormsApp1.ServiceReference1.stergeMagazieRequest request) {
            return base.Channel.stergeMagazie(request);
        }
        
        public string stergeMagazie(int ProdusId) {
            WindowsFormsApp1.ServiceReference1.stergeMagazieRequest inValue = new WindowsFormsApp1.ServiceReference1.stergeMagazieRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.stergeMagazieRequestBody();
            inValue.Body.ProdusId = ProdusId;
            WindowsFormsApp1.ServiceReference1.stergeMagazieResponse retVal = ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).stergeMagazie(inValue);
            return retVal.Body.stergeMagazieResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.stergeMagazieResponse> WindowsFormsApp1.ServiceReference1.WebService1Soap.stergeMagazieAsync(WindowsFormsApp1.ServiceReference1.stergeMagazieRequest request) {
            return base.Channel.stergeMagazieAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.stergeMagazieResponse> stergeMagazieAsync(int ProdusId) {
            WindowsFormsApp1.ServiceReference1.stergeMagazieRequest inValue = new WindowsFormsApp1.ServiceReference1.stergeMagazieRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.stergeMagazieRequestBody();
            inValue.Body.ProdusId = ProdusId;
            return ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).stergeMagazieAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WindowsFormsApp1.ServiceReference1.plaseazaComandaResponse WindowsFormsApp1.ServiceReference1.WebService1Soap.plaseazaComanda(WindowsFormsApp1.ServiceReference1.plaseazaComandaRequest request) {
            return base.Channel.plaseazaComanda(request);
        }
        
        public string plaseazaComanda(string NumeProdus, int Bucati) {
            WindowsFormsApp1.ServiceReference1.plaseazaComandaRequest inValue = new WindowsFormsApp1.ServiceReference1.plaseazaComandaRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.plaseazaComandaRequestBody();
            inValue.Body.NumeProdus = NumeProdus;
            inValue.Body.Bucati = Bucati;
            WindowsFormsApp1.ServiceReference1.plaseazaComandaResponse retVal = ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).plaseazaComanda(inValue);
            return retVal.Body.plaseazaComandaResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.plaseazaComandaResponse> WindowsFormsApp1.ServiceReference1.WebService1Soap.plaseazaComandaAsync(WindowsFormsApp1.ServiceReference1.plaseazaComandaRequest request) {
            return base.Channel.plaseazaComandaAsync(request);
        }
        
        public System.Threading.Tasks.Task<WindowsFormsApp1.ServiceReference1.plaseazaComandaResponse> plaseazaComandaAsync(string NumeProdus, int Bucati) {
            WindowsFormsApp1.ServiceReference1.plaseazaComandaRequest inValue = new WindowsFormsApp1.ServiceReference1.plaseazaComandaRequest();
            inValue.Body = new WindowsFormsApp1.ServiceReference1.plaseazaComandaRequestBody();
            inValue.Body.NumeProdus = NumeProdus;
            inValue.Body.Bucati = Bucati;
            return ((WindowsFormsApp1.ServiceReference1.WebService1Soap)(this)).plaseazaComandaAsync(inValue);
        }
    }
}
