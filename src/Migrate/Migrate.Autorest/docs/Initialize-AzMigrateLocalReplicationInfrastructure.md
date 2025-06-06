---
external help file:
Module Name: Az.Migrate
online version: https://learn.microsoft.com/powershell/module/az.migrate/initialize-azmigratelocalreplicationinfrastructure
schema: 2.0.0
---

# Initialize-AzMigrateLocalReplicationInfrastructure

## SYNOPSIS
Initializes the infrastructure for the migrate project.

## SYNTAX

```
Initialize-AzMigrateLocalReplicationInfrastructure -ProjectName <String> -ResourceGroupName <String>
 -SourceApplianceName <String> -TargetApplianceName <String> [-CacheStorageAccountId <String>]
 [-SubscriptionId <String>] [-DefaultProfile <PSObject>] [-PassThru] [-Confirm] [-WhatIf] [<CommonParameters>]
```

## DESCRIPTION
The Initialize-AzMigrateLocalReplicationInfrastructure cmdlet initializes the infrastructure for the migrate project in AzLocal scenario.

## EXAMPLES

### Example 1: Initialize AzLocal replication infrastructure
```powershell
Initialize-AzMigrateLocalReplicationInfrastructure -ProjectName "testproj" -ResourceGroupName "test-rg" -SourceApplianceName "testsrcapp" -TargetApplianceName "testtgtapp" -PassThru:$true
```

```output
$true
```

Initialize AzLocal replication infrastructure.
Cache storage account, replication policy, and replication extension will be created automatically.

### Example 2: Initialize AzLocal replication infrastructure with custom cache storage account
```powershell
$cacheStorageAccountId = "/subscriptions/xxx-xxx-xxxx/resourceGroups/test-rg/providers/Microsoft.Storage/storageAccounts/testSa"

Initialize-AzMigrateLocalReplicationInfrastructure -ProjectName "testproj" -ResourceGroupName "test-rg" -CacheStorageAccountId $cacheStorageAccountId -SourceApplianceName "testsrcapp" -TargetApplianceName "testtgtapp" -PassThru:$true
```

```output
$true
```

Initialize AzLocal replication infrastructure with custom cache storage account.
Replication policy and replication extension will be created automatically.

## PARAMETERS

### -CacheStorageAccountId
Specifies the Storage Account ARM Id to be used for private endpoint scenario.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -PassThru
Returns true when the command succeeds

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ProjectName
Specifies the name of the Azure Migrate project to be used for server migration.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Specifies the Resource Group of the Azure Migrate Project in the current subscription.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SourceApplianceName
Specifies the source appliance name for the AzLocal scenario.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -SubscriptionId
Azure Subscription ID.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
```

### -TargetApplianceName
Specifies the target appliance name for the AzLocal scenario.

```yaml
Type: System.String
Parameter Sets: (All)
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Confirm
Prompts you for confirmation before running the cmdlet.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: cf

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -WhatIf
Shows what would happen if the cmdlet runs.
The cmdlet is not run.

```yaml
Type: System.Management.Automation.SwitchParameter
Parameter Sets: (All)
Aliases: wi

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

## OUTPUTS

### System.Boolean

## NOTES

## RELATED LINKS

