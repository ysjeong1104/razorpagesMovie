최초 프로젝트 생성후 EF core 관련 패키지 설치
.NET CLI

복사
dotnet tool uninstall --global dotnet-aspnet-codegenerator
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet tool uninstall --global dotnet-ef
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Tools

클래스 생성후 아래 명령 실행
Program.cs 및 .csproj 파일이 포함된 프로젝트 디렉터리에서 명령 셸을 엽니다. 다음 명령을 실행합니다.

.NET CLI

DB공급자에 따라 맨끝의 내용 수정
복사
dotnet aspnet-codegenerator razorpage -m Movie -dc RazorPagesMovie.Data.RazorPagesMovieContext -udl -outDir Pages/Movies --referenceScriptLibraries --databaseProvider sqlite


다음 표에서는 ASP.NET Core 코드 생성기 옵션을 자세히 설명합니다.

옵션	설명
-m	모델의 이름입니다.
-dc	네임스페이스를 포함하여 사용할 DbContext 클래스입니다.
-udl	기본 레이아웃을 사용합니다.
-outDir	뷰를 만들기 위한 상태 출력 폴더 경로입니다.
--referenceScriptLibraries	Edit 및 Create 페이지에 _ValidationScriptsPartial을 추가합니다.

스캐폴딩 작업 후 마이그레이션 하여 table 생성

dotnet ef migrations add InitialCreate(마이그레이션 진행 할때마다 이름 변경) --context (마이그레이션할 컨텍스트)
dotnet ef database update --context (마이그레이션할 컨텍스트)
