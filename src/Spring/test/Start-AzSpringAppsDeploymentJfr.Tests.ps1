if(($null -eq $TestName) -or ($TestName -contains 'Start-AzSpringAppsDeploymentJfr'))
{
  $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
  if (-Not (Test-Path -Path $loadEnvPath)) {
      $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
  }
  . ($loadEnvPath)
  $TestRecordingFile = Join-Path $PSScriptRoot 'Start-AzSpringAppsDeploymentJfr.Recording.json'
  $currentPath = $PSScriptRoot
  while(-not $mockingPath) {
      $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
      $currentPath = Split-Path -Path $currentPath -Parent
  }
  . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'Start-AzSpringAppsDeploymentJfr' {
    It 'StartExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'StartViaJsonString' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'StartViaJsonFilePath' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'StartViaIdentitySpringExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'StartViaIdentitySpring' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'Start' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'StartViaIdentityAppExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'StartViaIdentityApp' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'StartViaIdentityExpanded' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }

    It 'StartViaIdentity' -skip {
        { throw [System.NotImplementedException] } | Should -Not -Throw
    }
}
