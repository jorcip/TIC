﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Ce code a été généré par un outil.
'     Version du runtime :4.0.30319.42000
'
'     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
'     le code est régénéré.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'Cette classe a été générée automatiquement par la classe StronglyTypedResourceBuilder
    'à l'aide d'un outil, tel que ResGen ou Visual Studio.
    'Pour ajouter ou supprimer un membre, modifiez votre fichier .ResX, puis réexécutez ResGen
    'avec l'option /str ou régénérez votre projet VS.
    '''<summary>
    '''  Une classe de ressource fortement typée destinée, entre autres, à la consultation des chaînes localisées.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class Messages
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Retourne l'instance ResourceManager mise en cache utilisée par cette classe.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("WindowsApplication1.Messages", GetType(Messages).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Remplace la propriété CurrentUICulture du thread actuel pour toutes
        '''  les recherches de ressources à l'aide de cette classe de ressource fortement typée.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le fichier de sauvegarde est introuvable ! Continuer pour générer un nouveau fichier ?.
        '''</summary>
        Friend Shared ReadOnly Property Backup_errorMessage() As String
            Get
                Return ResourceManager.GetString("Backup_errorMessage", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Erreur: Fichier de sauvegarde introuvable.
        '''</summary>
        Friend Shared ReadOnly Property Backup_errorTitle() As String
            Get
                Return ResourceManager.GetString("Backup_errorTitle", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le fichier de sauvegarde a été créé avec succès !.
        '''</summary>
        Friend Shared ReadOnly Property Backup_success() As String
            Get
                Return ResourceManager.GetString("Backup_success", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Voulez-vous vraiment supprimer ce dossier ?.
        '''</summary>
        Friend Shared ReadOnly Property DeleteDossier_Message() As String
            Get
                Return ResourceManager.GetString("DeleteDossier_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Supprimer un dossier.
        '''</summary>
        Friend Shared ReadOnly Property DeleteDossier_Title() As String
            Get
                Return ResourceManager.GetString("DeleteDossier_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Vous êtes sur le point de modifier le dossier, voulez-vous continuer ?.
        '''</summary>
        Friend Shared ReadOnly Property EditDossier_Message() As String
            Get
                Return ResourceManager.GetString("EditDossier_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le dossier a été modifié avec succès !.
        '''</summary>
        Friend Shared ReadOnly Property EditDossier_Success() As String
            Get
                Return ResourceManager.GetString("EditDossier_Success", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Modifier un dossier.
        '''</summary>
        Friend Shared ReadOnly Property EditDossier_Title() As String
            Get
                Return ResourceManager.GetString("EditDossier_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Une version antérieure de Microsoft Excel est installée sur cet ordinateur.
        '''Veuillez installer la mise à jour vers Microsoft Excel 16.x.
        '''</summary>
        Friend Shared ReadOnly Property Excel_BadVersion() As String
            Get
                Return ResourceManager.GetString("Excel_BadVersion", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Bienvenue sur UBDXFORM
        '''Veuillez sélectionner l&apos;emplacement de sauvegarde de l&apos;application. Vous pourrez modifier votre choix ultérieurement dans l&apos;onglet Configuration.
        '''</summary>
        Friend Shared ReadOnly Property FirstOpening_Message() As String
            Get
                Return ResourceManager.GetString("FirstOpening_Message", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Bienvenue sur UBDXFORM.
        '''</summary>
        Friend Shared ReadOnly Property FirstOpening_Title() As String
            Get
                Return ResourceManager.GetString("FirstOpening_Title", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à Le dossier d&apos;inscription a été généré avec succès !.
        '''</summary>
        Friend Shared ReadOnly Property GenerateDossier_Success() As String
            Get
                Return ResourceManager.GetString("GenerateDossier_Success", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Recherche une chaîne localisée semblable à L&apos;inscription a été ajoutée avec succès !.
        '''</summary>
        Friend Shared ReadOnly Property Inscription_Success() As String
            Get
                Return ResourceManager.GetString("Inscription_Success", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
