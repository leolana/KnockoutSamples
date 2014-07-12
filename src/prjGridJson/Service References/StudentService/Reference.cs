﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace prjGridJson.StudentService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/SchoolService")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CEPField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private prjGridJson.StudentService.Course[] CoursesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StudentNameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CEP {
            get {
                return this.CEPField;
            }
            set {
                if ((object.ReferenceEquals(this.CEPField, value) != true)) {
                    this.CEPField = value;
                    this.RaisePropertyChanged("CEP");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public prjGridJson.StudentService.Course[] Courses {
            get {
                return this.CoursesField;
            }
            set {
                if ((object.ReferenceEquals(this.CoursesField, value) != true)) {
                    this.CoursesField = value;
                    this.RaisePropertyChanged("Courses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentId {
            get {
                return this.StudentIdField;
            }
            set {
                if ((this.StudentIdField.Equals(value) != true)) {
                    this.StudentIdField = value;
                    this.RaisePropertyChanged("StudentId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentName {
            get {
                return this.StudentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentNameField, value) != true)) {
                    this.StudentNameField = value;
                    this.RaisePropertyChanged("StudentName");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Course", Namespace="http://schemas.datacontract.org/2004/07/SchoolService.Models")]
    [System.SerializableAttribute()]
    public partial class Course : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CompletionDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int CourseIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CourseNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private prjGridJson.StudentService.Student[] StudentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int[] StudentsIDsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime CompletionDate {
            get {
                return this.CompletionDateField;
            }
            set {
                if ((this.CompletionDateField.Equals(value) != true)) {
                    this.CompletionDateField = value;
                    this.RaisePropertyChanged("CompletionDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CourseID {
            get {
                return this.CourseIDField;
            }
            set {
                if ((this.CourseIDField.Equals(value) != true)) {
                    this.CourseIDField = value;
                    this.RaisePropertyChanged("CourseID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CourseName {
            get {
                return this.CourseNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CourseNameField, value) != true)) {
                    this.CourseNameField = value;
                    this.RaisePropertyChanged("CourseName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public prjGridJson.StudentService.Student[] Students {
            get {
                return this.StudentsField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentsField, value) != true)) {
                    this.StudentsField = value;
                    this.RaisePropertyChanged("Students");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int[] StudentsIDs {
            get {
                return this.StudentsIDsField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentsIDsField, value) != true)) {
                    this.StudentsIDsField = value;
                    this.RaisePropertyChanged("StudentsIDs");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentService.IStudentService")]
    public interface IStudentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetAllStudents", ReplyAction="http://tempuri.org/IStudentService/GetAllStudentsResponse")]
        prjGridJson.StudentService.Student[] GetAllStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetStudentByID", ReplyAction="http://tempuri.org/IStudentService/GetStudentByIDResponse")]
        prjGridJson.StudentService.Student GetStudentByID(int StudentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/Save", ReplyAction="http://tempuri.org/IStudentService/SaveResponse")]
        bool Save(prjGridJson.StudentService.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/Delete", ReplyAction="http://tempuri.org/IStudentService/DeleteResponse")]
        bool Delete(int studentID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentServiceChannel : prjGridJson.StudentService.IStudentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentServiceClient : System.ServiceModel.ClientBase<prjGridJson.StudentService.IStudentService>, prjGridJson.StudentService.IStudentService {
        
        public StudentServiceClient() {
        }
        
        public StudentServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public prjGridJson.StudentService.Student[] GetAllStudents() {
            return base.Channel.GetAllStudents();
        }
        
        public prjGridJson.StudentService.Student GetStudentByID(int StudentID) {
            return base.Channel.GetStudentByID(StudentID);
        }
        
        public bool Save(prjGridJson.StudentService.Student student) {
            return base.Channel.Save(student);
        }
        
        public bool Delete(int studentID) {
            return base.Channel.Delete(studentID);
        }
    }
}