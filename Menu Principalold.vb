Option Explicit On 
Imports Cuentas_por_Cobrar
Imports Facturacion
Imports Bancos
Imports Cuentas_por_Pagar
Imports Configuracion_Sistema.ini
Imports Configuracion_Sistema.Coneccion
Imports Contabilidad
Imports Inventario
Imports Activos_Fijos
Imports Administrador_Sistema
Imports Nomina


Public Class Menu_principal
  Inherits System.Windows.Forms.Form
  Dim tser
  Dim tbas
  Dim tusu
  Dim tpas
  Dim ttip
  Dim modelo_fac
  Dim tipo_secci
#Region " Windows Form Designer generated code "

  Public Sub New()
    MyBase.New()

    'This call is required by the Windows Form Designer.
    InitializeComponent()

    'Add any initialization after the InitializeComponent() call

  End Sub

  'Form overrides dispose to clean up the component list.
  Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
    If disposing Then
      If Not (components Is Nothing) Then
        components.Dispose()
      End If
    End If
    MyBase.Dispose(disposing)
  End Sub

  'Required by the Windows Form Designer
  Private components As System.ComponentModel.IContainer

  'NOTE: The following procedure is required by the Windows Form Designer
  'It can be modified using the Windows Form Designer.  
  'Do not modify it using the code editor.
  Friend WithEvents Timer1 As System.Windows.Forms.Timer
  Friend WithEvents tab1 As System.Windows.Forms.TabControl
  Friend WithEvents cxp As System.Windows.Forms.MainMenu
  Friend WithEvents MenuItem7 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem9 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem10 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem8 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem11 As System.Windows.Forms.MenuItem
  Friend WithEvents cxc As System.Windows.Forms.MainMenu
  Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem14 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem15 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem16 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem17 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem18 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem19 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem20 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
  Friend WithEvents inv As System.Windows.Forms.MainMenu
  Friend WithEvents MenuItem22 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem23 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem24 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem26 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem27 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem28 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem29 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem30 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem31 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem32 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem33 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem34 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem35 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem36 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem44 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem46 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem42 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem49 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem51 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem52 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem53 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem56 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem57 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem58 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem59 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem60 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem61 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem62 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem63 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem64 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem67 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem69 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem71 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem86 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem87 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem88 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem89 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem90 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem92 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem93 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem94 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem83 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem84 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem85 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem95 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem13 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem96 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem97 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem98 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem99 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem100 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem101 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem103 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem54 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem55 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem104 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem105 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem106 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem107 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem108 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem109 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem110 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem111 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem112 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem113 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem50 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem114 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem115 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem116 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem117 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem118 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem119 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem120 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem121 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem122 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem123 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem125 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem134 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem135 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem136 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem137 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem138 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem139 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem141 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem142 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem144 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem145 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem146 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem148 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem149 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem151 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem152 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem153 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem154 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem155 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem156 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem157 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem158 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem159 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem160 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem161 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem162 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem163 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem164 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem165 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem124 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem126 As System.Windows.Forms.MenuItem
  Friend WithEvents ImageList2 As System.Windows.Forms.ImageList
  Friend WithEvents fac As System.Windows.Forms.MainMenu
  Friend WithEvents nom As System.Windows.Forms.MainMenu
  Friend WithEvents ban As System.Windows.Forms.MainMenu
  Friend WithEvents cnt As System.Windows.Forms.MainMenu
  Friend WithEvents act As System.Windows.Forms.MainMenu
  Friend WithEvents MenuItem127 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem128 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem129 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem130 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem131 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem132 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem133 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem140 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem143 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem147 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem150 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem166 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem167 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem168 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem169 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem170 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem171 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem172 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem173 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem174 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem175 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem176 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem177 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem178 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem179 As System.Windows.Forms.MenuItem
  Friend WithEvents s1 As System.Windows.Forms.StatusBar
  Friend WithEvents p1 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents p2 As System.Windows.Forms.StatusBarPanel
  Friend WithEvents MenuItem180 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem181 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem182 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem183 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem184 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem185 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem186 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem187 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem188 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem189 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem190 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem191 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem192 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem194 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem193 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem195 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem196 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem197 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem198 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem199 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem200 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem201 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem244 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem214 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem202 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem203 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem204 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem205 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem206 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem207 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem208 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem209 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem210 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem211 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem212 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem213 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem215 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem216 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem217 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem218 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem220 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem221 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem222 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem224 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem225 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem219 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem226 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem227 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem223 As System.Windows.Forms.MenuItem
  Friend WithEvents acxc As System.Windows.Forms.TabPage
  Friend WithEvents ainv As System.Windows.Forms.TabPage
  Friend WithEvents anom As System.Windows.Forms.TabPage
  Friend WithEvents aban As System.Windows.Forms.TabPage
  Friend WithEvents aact As System.Windows.Forms.TabPage
  Friend WithEvents acxp As System.Windows.Forms.TabPage
  Friend WithEvents afac As System.Windows.Forms.TabPage
  Friend WithEvents acnt As System.Windows.Forms.TabPage
  Friend WithEvents MenuItem228 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem229 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem230 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem231 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem232 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem233 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem234 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem235 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem236 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem237 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem238 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem239 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem240 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem241 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem242 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem243 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem245 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem246 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem247 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem248 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem249 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem250 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem251 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem252 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem253 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem254 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem255 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem256 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem257 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem258 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem47 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem259 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem260 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem261 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem262 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem263 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem264 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem265 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem266 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem267 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem268 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem269 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem270 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem271 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem272 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem91 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem273 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem274 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem275 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem276 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem277 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem102 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem278 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem279 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem280 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem281 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem282 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem283 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem284 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem285 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem286 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem287 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem288 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem289 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem290 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem291 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem292 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem293 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem294 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem295 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem296 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem297 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem25 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem298 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem299 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem300 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem301 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem302 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem303 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem304 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem305 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem306 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem307 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem308 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem309 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem310 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem311 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem313 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem314 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem315 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem316 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem317 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem318 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem319 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem320 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem321 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem322 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem323 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem324 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem325 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem326 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem327 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem328 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem329 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem330 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem331 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem332 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem312 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem333 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem334 As System.Windows.Forms.MenuItem
  Friend WithEvents adm As System.Windows.Forms.MainMenu
  Friend WithEvents MenuItem335 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem336 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem337 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem339 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem338 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem341 As System.Windows.Forms.MenuItem
  Friend WithEvents aadm As System.Windows.Forms.TabPage
  Friend WithEvents Pentra As System.Windows.Forms.ProgressBar
  Friend WithEvents MenuItem342 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem343 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem340 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem344 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem345 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem346 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem347 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem348 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem349 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem350 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem351 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem352 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem353 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem356 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem357 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem358 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem359 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem355 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem360 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem361 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem362 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem363 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem368 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem369 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem370 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem371 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem372 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem376 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem377 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem378 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem379 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem380 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem381 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem382 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem383 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem384 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem385 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem386 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem387 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem388 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem389 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem390 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem391 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem392 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem393 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem394 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem396 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem397 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem398 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem399 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem400 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem354 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem364 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem365 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem366 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem401 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem402 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem403 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem404 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem405 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem406 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem407 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem408 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem409 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem410 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem412 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem413 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem414 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem415 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem416 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem417 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem418 As System.Windows.Forms.MenuItem
  Friend WithEvents ani As System.Windows.Forms.MainMenu
  Friend WithEvents MenuItem419 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem432 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem440 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem503 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem504 As System.Windows.Forms.MenuItem
  Friend WithEvents aani As System.Windows.Forms.TabPage
  Friend WithEvents MenuItem420 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem421 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem422 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem423 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem424 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem425 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem426 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem427 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem428 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem429 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem431 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem434 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem435 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem437 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem439 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem441 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem430 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem433 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem436 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem438 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem442 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem443 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem444 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem445 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem446 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem447 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem448 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem449 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem450 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem451 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem452 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem453 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem454 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem455 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem456 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem457 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem458 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem459 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem460 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem461 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem462 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem463 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem464 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem465 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem466 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem467 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem468 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem469 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem470 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem471 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem472 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem473 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem474 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem475 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem476 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem477 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem478 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem479 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem480 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem481 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem482 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem483 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem484 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem486 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem487 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem485 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem488 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem489 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem490 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem491 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem492 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem493 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem494 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem495 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem496 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem497 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem498 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem499 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem500 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem501 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem502 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem505 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem506 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem507 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem508 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem509 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem510 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem511 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem512 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem513 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem514 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem515 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem516 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem517 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem518 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem519 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem520 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem521 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem522 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem523 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem524 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem525 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem526 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem527 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem528 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem529 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem530 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem531 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem532 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem533 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem534 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem535 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem536 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem537 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem538 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem539 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem540 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem541 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem542 As System.Windows.Forms.MenuItem
  Friend WithEvents MenuItem543 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem544 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem545 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem546 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem547 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem548 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem549 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem550 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem551 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem552 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem553 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem554 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem555 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem556 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem557 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem558 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem559 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem560 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem561 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem562 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem563 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem564 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem565 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem566 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem567 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem568 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem569 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem570 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem367 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem373 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem374 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem375 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem395 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem411 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem571 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem572 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem573 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem574 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem575 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem576 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem577 As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Menu_principal))
        Me.tab1 = New System.Windows.Forms.TabControl
        Me.ainv = New System.Windows.Forms.TabPage
        Me.acxc = New System.Windows.Forms.TabPage
        Me.anom = New System.Windows.Forms.TabPage
        Me.aban = New System.Windows.Forms.TabPage
        Me.aact = New System.Windows.Forms.TabPage
        Me.acxp = New System.Windows.Forms.TabPage
        Me.afac = New System.Windows.Forms.TabPage
        Me.acnt = New System.Windows.Forms.TabPage
        Me.aani = New System.Windows.Forms.TabPage
        Me.aadm = New System.Windows.Forms.TabPage
        Me.MenuItem7 = New System.Windows.Forms.MenuItem
        Me.MenuItem9 = New System.Windows.Forms.MenuItem
        Me.MenuItem10 = New System.Windows.Forms.MenuItem
        Me.MenuItem107 = New System.Windows.Forms.MenuItem
        Me.MenuItem104 = New System.Windows.Forms.MenuItem
        Me.MenuItem106 = New System.Windows.Forms.MenuItem
        Me.MenuItem108 = New System.Windows.Forms.MenuItem
        Me.MenuItem126 = New System.Windows.Forms.MenuItem
        Me.MenuItem105 = New System.Windows.Forms.MenuItem
        Me.MenuItem8 = New System.Windows.Forms.MenuItem
        Me.MenuItem11 = New System.Windows.Forms.MenuItem
        Me.MenuItem112 = New System.Windows.Forms.MenuItem
        Me.MenuItem109 = New System.Windows.Forms.MenuItem
        Me.MenuItem110 = New System.Windows.Forms.MenuItem
        Me.MenuItem113 = New System.Windows.Forms.MenuItem
        Me.MenuItem111 = New System.Windows.Forms.MenuItem
        Me.MenuItem50 = New System.Windows.Forms.MenuItem
        Me.MenuItem114 = New System.Windows.Forms.MenuItem
        Me.MenuItem115 = New System.Windows.Forms.MenuItem
        Me.MenuItem116 = New System.Windows.Forms.MenuItem
        Me.MenuItem117 = New System.Windows.Forms.MenuItem
        Me.MenuItem118 = New System.Windows.Forms.MenuItem
        Me.MenuItem119 = New System.Windows.Forms.MenuItem
        Me.MenuItem120 = New System.Windows.Forms.MenuItem
        Me.MenuItem121 = New System.Windows.Forms.MenuItem
        Me.MenuItem122 = New System.Windows.Forms.MenuItem
        Me.MenuItem123 = New System.Windows.Forms.MenuItem
        Me.MenuItem125 = New System.Windows.Forms.MenuItem
        Me.MenuItem124 = New System.Windows.Forms.MenuItem
        Me.MenuItem134 = New System.Windows.Forms.MenuItem
        Me.MenuItem135 = New System.Windows.Forms.MenuItem
        Me.MenuItem136 = New System.Windows.Forms.MenuItem
        Me.MenuItem137 = New System.Windows.Forms.MenuItem
        Me.MenuItem138 = New System.Windows.Forms.MenuItem
        Me.MenuItem139 = New System.Windows.Forms.MenuItem
        Me.MenuItem141 = New System.Windows.Forms.MenuItem
        Me.MenuItem142 = New System.Windows.Forms.MenuItem
        Me.MenuItem144 = New System.Windows.Forms.MenuItem
        Me.MenuItem145 = New System.Windows.Forms.MenuItem
        Me.MenuItem146 = New System.Windows.Forms.MenuItem
        Me.MenuItem148 = New System.Windows.Forms.MenuItem
        Me.MenuItem149 = New System.Windows.Forms.MenuItem
        Me.MenuItem290 = New System.Windows.Forms.MenuItem
        Me.MenuItem291 = New System.Windows.Forms.MenuItem
        Me.MenuItem540 = New System.Windows.Forms.MenuItem
        Me.MenuItem541 = New System.Windows.Forms.MenuItem
        Me.MenuItem151 = New System.Windows.Forms.MenuItem
        Me.MenuItem152 = New System.Windows.Forms.MenuItem
        Me.MenuItem153 = New System.Windows.Forms.MenuItem
        Me.MenuItem154 = New System.Windows.Forms.MenuItem
        Me.MenuItem155 = New System.Windows.Forms.MenuItem
        Me.MenuItem156 = New System.Windows.Forms.MenuItem
        Me.MenuItem157 = New System.Windows.Forms.MenuItem
        Me.MenuItem158 = New System.Windows.Forms.MenuItem
        Me.MenuItem159 = New System.Windows.Forms.MenuItem
        Me.MenuItem160 = New System.Windows.Forms.MenuItem
        Me.MenuItem161 = New System.Windows.Forms.MenuItem
        Me.MenuItem283 = New System.Windows.Forms.MenuItem
        Me.MenuItem286 = New System.Windows.Forms.MenuItem
        Me.MenuItem287 = New System.Windows.Forms.MenuItem
        Me.MenuItem288 = New System.Windows.Forms.MenuItem
        Me.MenuItem284 = New System.Windows.Forms.MenuItem
        Me.MenuItem285 = New System.Windows.Forms.MenuItem
        Me.MenuItem162 = New System.Windows.Forms.MenuItem
        Me.MenuItem163 = New System.Windows.Forms.MenuItem
        Me.MenuItem164 = New System.Windows.Forms.MenuItem
        Me.MenuItem165 = New System.Windows.Forms.MenuItem
        Me.MenuItem289 = New System.Windows.Forms.MenuItem
        Me.MenuItem292 = New System.Windows.Forms.MenuItem
        Me.MenuItem551 = New System.Windows.Forms.MenuItem
        Me.MenuItem54 = New System.Windows.Forms.MenuItem
        Me.MenuItem55 = New System.Windows.Forms.MenuItem
        Me.cxc = New System.Windows.Forms.MainMenu
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.MenuItem17 = New System.Windows.Forms.MenuItem
        Me.MenuItem20 = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.MenuItem33 = New System.Windows.Forms.MenuItem
        Me.MenuItem16 = New System.Windows.Forms.MenuItem
        Me.MenuItem18 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem19 = New System.Windows.Forms.MenuItem
        Me.MenuItem35 = New System.Windows.Forms.MenuItem
        Me.MenuItem31 = New System.Windows.Forms.MenuItem
        Me.MenuItem32 = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.MenuItem36 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem42 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem49 = New System.Windows.Forms.MenuItem
        Me.MenuItem52 = New System.Windows.Forms.MenuItem
        Me.MenuItem92 = New System.Windows.Forms.MenuItem
        Me.MenuItem93 = New System.Windows.Forms.MenuItem
        Me.MenuItem94 = New System.Windows.Forms.MenuItem
        Me.MenuItem53 = New System.Windows.Forms.MenuItem
        Me.MenuItem56 = New System.Windows.Forms.MenuItem
        Me.MenuItem57 = New System.Windows.Forms.MenuItem
        Me.MenuItem58 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem59 = New System.Windows.Forms.MenuItem
        Me.MenuItem60 = New System.Windows.Forms.MenuItem
        Me.MenuItem61 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem62 = New System.Windows.Forms.MenuItem
        Me.MenuItem63 = New System.Windows.Forms.MenuItem
        Me.MenuItem67 = New System.Windows.Forms.MenuItem
        Me.MenuItem64 = New System.Windows.Forms.MenuItem
        Me.MenuItem51 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem69 = New System.Windows.Forms.MenuItem
        Me.MenuItem73 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem71 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.MenuItem74 = New System.Windows.Forms.MenuItem
        Me.MenuItem75 = New System.Windows.Forms.MenuItem
        Me.MenuItem77 = New System.Windows.Forms.MenuItem
        Me.MenuItem78 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.MenuItem81 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        Me.MenuItem83 = New System.Windows.Forms.MenuItem
        Me.MenuItem76 = New System.Windows.Forms.MenuItem
        Me.MenuItem86 = New System.Windows.Forms.MenuItem
        Me.MenuItem13 = New System.Windows.Forms.MenuItem
        Me.MenuItem96 = New System.Windows.Forms.MenuItem
        Me.MenuItem97 = New System.Windows.Forms.MenuItem
        Me.MenuItem87 = New System.Windows.Forms.MenuItem
        Me.MenuItem98 = New System.Windows.Forms.MenuItem
        Me.MenuItem99 = New System.Windows.Forms.MenuItem
        Me.MenuItem100 = New System.Windows.Forms.MenuItem
        Me.MenuItem84 = New System.Windows.Forms.MenuItem
        Me.MenuItem85 = New System.Windows.Forms.MenuItem
        Me.MenuItem102 = New System.Windows.Forms.MenuItem
        Me.MenuItem280 = New System.Windows.Forms.MenuItem
        Me.MenuItem281 = New System.Windows.Forms.MenuItem
        Me.MenuItem282 = New System.Windows.Forms.MenuItem
        Me.MenuItem278 = New System.Windows.Forms.MenuItem
        Me.MenuItem277 = New System.Windows.Forms.MenuItem
        Me.MenuItem101 = New System.Windows.Forms.MenuItem
        Me.MenuItem279 = New System.Windows.Forms.MenuItem
        Me.MenuItem103 = New System.Windows.Forms.MenuItem
        Me.MenuItem95 = New System.Windows.Forms.MenuItem
        Me.MenuItem293 = New System.Windows.Forms.MenuItem
        Me.MenuItem294 = New System.Windows.Forms.MenuItem
        Me.MenuItem550 = New System.Windows.Forms.MenuItem
        Me.MenuItem409 = New System.Windows.Forms.MenuItem
        Me.MenuItem410 = New System.Windows.Forms.MenuItem
        Me.MenuItem14 = New System.Windows.Forms.MenuItem
        Me.MenuItem15 = New System.Windows.Forms.MenuItem
        Me.inv = New System.Windows.Forms.MainMenu
        Me.MenuItem22 = New System.Windows.Forms.MenuItem
        Me.MenuItem28 = New System.Windows.Forms.MenuItem
        Me.MenuItem249 = New System.Windows.Forms.MenuItem
        Me.MenuItem250 = New System.Windows.Forms.MenuItem
        Me.MenuItem251 = New System.Windows.Forms.MenuItem
        Me.MenuItem252 = New System.Windows.Forms.MenuItem
        Me.MenuItem253 = New System.Windows.Forms.MenuItem
        Me.MenuItem254 = New System.Windows.Forms.MenuItem
        Me.MenuItem255 = New System.Windows.Forms.MenuItem
        Me.MenuItem256 = New System.Windows.Forms.MenuItem
        Me.MenuItem257 = New System.Windows.Forms.MenuItem
        Me.MenuItem258 = New System.Windows.Forms.MenuItem
        Me.MenuItem270 = New System.Windows.Forms.MenuItem
        Me.MenuItem271 = New System.Windows.Forms.MenuItem
        Me.MenuItem29 = New System.Windows.Forms.MenuItem
        Me.MenuItem30 = New System.Windows.Forms.MenuItem
        Me.MenuItem34 = New System.Windows.Forms.MenuItem
        Me.MenuItem44 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem46 = New System.Windows.Forms.MenuItem
        Me.MenuItem362 = New System.Windows.Forms.MenuItem
        Me.MenuItem363 = New System.Windows.Forms.MenuItem
        Me.MenuItem557 = New System.Windows.Forms.MenuItem
        Me.MenuItem23 = New System.Windows.Forms.MenuItem
        Me.MenuItem88 = New System.Windows.Forms.MenuItem
        Me.MenuItem89 = New System.Windows.Forms.MenuItem
        Me.MenuItem295 = New System.Windows.Forms.MenuItem
        Me.MenuItem90 = New System.Windows.Forms.MenuItem
        Me.MenuItem406 = New System.Windows.Forms.MenuItem
        Me.MenuItem407 = New System.Windows.Forms.MenuItem
        Me.MenuItem527 = New System.Windows.Forms.MenuItem
        Me.MenuItem558 = New System.Windows.Forms.MenuItem
        Me.MenuItem559 = New System.Windows.Forms.MenuItem
        Me.MenuItem566 = New System.Windows.Forms.MenuItem
        Me.MenuItem24 = New System.Windows.Forms.MenuItem
        Me.MenuItem47 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem259 = New System.Windows.Forms.MenuItem
        Me.MenuItem260 = New System.Windows.Forms.MenuItem
        Me.MenuItem261 = New System.Windows.Forms.MenuItem
        Me.MenuItem262 = New System.Windows.Forms.MenuItem
        Me.MenuItem263 = New System.Windows.Forms.MenuItem
        Me.MenuItem264 = New System.Windows.Forms.MenuItem
        Me.MenuItem265 = New System.Windows.Forms.MenuItem
        Me.MenuItem266 = New System.Windows.Forms.MenuItem
        Me.MenuItem267 = New System.Windows.Forms.MenuItem
        Me.MenuItem268 = New System.Windows.Forms.MenuItem
        Me.MenuItem269 = New System.Windows.Forms.MenuItem
        Me.MenuItem272 = New System.Windows.Forms.MenuItem
        Me.MenuItem91 = New System.Windows.Forms.MenuItem
        Me.MenuItem327 = New System.Windows.Forms.MenuItem
        Me.MenuItem328 = New System.Windows.Forms.MenuItem
        Me.MenuItem329 = New System.Windows.Forms.MenuItem
        Me.MenuItem330 = New System.Windows.Forms.MenuItem
        Me.MenuItem331 = New System.Windows.Forms.MenuItem
        Me.MenuItem332 = New System.Windows.Forms.MenuItem
        Me.MenuItem414 = New System.Windows.Forms.MenuItem
        Me.MenuItem415 = New System.Windows.Forms.MenuItem
        Me.MenuItem416 = New System.Windows.Forms.MenuItem
        Me.MenuItem477 = New System.Windows.Forms.MenuItem
        Me.MenuItem273 = New System.Windows.Forms.MenuItem
        Me.MenuItem274 = New System.Windows.Forms.MenuItem
        Me.MenuItem275 = New System.Windows.Forms.MenuItem
        Me.MenuItem276 = New System.Windows.Forms.MenuItem
        Me.MenuItem324 = New System.Windows.Forms.MenuItem
        Me.MenuItem478 = New System.Windows.Forms.MenuItem
        Me.MenuItem479 = New System.Windows.Forms.MenuItem
        Me.MenuItem530 = New System.Windows.Forms.MenuItem
        Me.MenuItem531 = New System.Windows.Forms.MenuItem
        Me.MenuItem535 = New System.Windows.Forms.MenuItem
        Me.MenuItem536 = New System.Windows.Forms.MenuItem
        Me.MenuItem537 = New System.Windows.Forms.MenuItem
        Me.MenuItem538 = New System.Windows.Forms.MenuItem
        Me.MenuItem539 = New System.Windows.Forms.MenuItem
        Me.MenuItem574 = New System.Windows.Forms.MenuItem
        Me.MenuItem575 = New System.Windows.Forms.MenuItem
        Me.MenuItem552 = New System.Windows.Forms.MenuItem
        Me.MenuItem553 = New System.Windows.Forms.MenuItem
        Me.MenuItem554 = New System.Windows.Forms.MenuItem
        Me.MenuItem556 = New System.Windows.Forms.MenuItem
        Me.MenuItem555 = New System.Windows.Forms.MenuItem
        Me.MenuItem325 = New System.Windows.Forms.MenuItem
        Me.MenuItem326 = New System.Windows.Forms.MenuItem
        Me.MenuItem333 = New System.Windows.Forms.MenuItem
        Me.MenuItem334 = New System.Windows.Forms.MenuItem
        Me.MenuItem26 = New System.Windows.Forms.MenuItem
        Me.MenuItem27 = New System.Windows.Forms.MenuItem
        Me.s1 = New System.Windows.Forms.StatusBar
        Me.p1 = New System.Windows.Forms.StatusBarPanel
        Me.p2 = New System.Windows.Forms.StatusBarPanel
        Me.fac = New System.Windows.Forms.MainMenu
        Me.MenuItem127 = New System.Windows.Forms.MenuItem
        Me.MenuItem182 = New System.Windows.Forms.MenuItem
        Me.MenuItem184 = New System.Windows.Forms.MenuItem
        Me.MenuItem180 = New System.Windows.Forms.MenuItem
        Me.MenuItem193 = New System.Windows.Forms.MenuItem
        Me.MenuItem185 = New System.Windows.Forms.MenuItem
        Me.MenuItem183 = New System.Windows.Forms.MenuItem
        Me.MenuItem181 = New System.Windows.Forms.MenuItem
        Me.MenuItem408 = New System.Windows.Forms.MenuItem
        Me.MenuItem393 = New System.Windows.Forms.MenuItem
        Me.MenuItem483 = New System.Windows.Forms.MenuItem
        Me.MenuItem484 = New System.Windows.Forms.MenuItem
        Me.MenuItem486 = New System.Windows.Forms.MenuItem
        Me.MenuItem487 = New System.Windows.Forms.MenuItem
        Me.MenuItem485 = New System.Windows.Forms.MenuItem
        Me.MenuItem488 = New System.Windows.Forms.MenuItem
        Me.MenuItem489 = New System.Windows.Forms.MenuItem
        Me.MenuItem569 = New System.Windows.Forms.MenuItem
        Me.MenuItem572 = New System.Windows.Forms.MenuItem
        Me.MenuItem573 = New System.Windows.Forms.MenuItem
        Me.MenuItem512 = New System.Windows.Forms.MenuItem
        Me.MenuItem513 = New System.Windows.Forms.MenuItem
        Me.MenuItem514 = New System.Windows.Forms.MenuItem
        Me.MenuItem515 = New System.Windows.Forms.MenuItem
        Me.MenuItem516 = New System.Windows.Forms.MenuItem
        Me.MenuItem128 = New System.Windows.Forms.MenuItem
        Me.MenuItem186 = New System.Windows.Forms.MenuItem
        Me.MenuItem188 = New System.Windows.Forms.MenuItem
        Me.MenuItem195 = New System.Windows.Forms.MenuItem
        Me.MenuItem187 = New System.Windows.Forms.MenuItem
        Me.MenuItem189 = New System.Windows.Forms.MenuItem
        Me.MenuItem190 = New System.Windows.Forms.MenuItem
        Me.MenuItem191 = New System.Windows.Forms.MenuItem
        Me.MenuItem25 = New System.Windows.Forms.MenuItem
        Me.MenuItem298 = New System.Windows.Forms.MenuItem
        Me.MenuItem560 = New System.Windows.Forms.MenuItem
        Me.MenuItem567 = New System.Windows.Forms.MenuItem
        Me.MenuItem568 = New System.Windows.Forms.MenuItem
        Me.MenuItem129 = New System.Windows.Forms.MenuItem
        Me.MenuItem192 = New System.Windows.Forms.MenuItem
        Me.MenuItem544 = New System.Windows.Forms.MenuItem
        Me.MenuItem545 = New System.Windows.Forms.MenuItem
        Me.MenuItem546 = New System.Windows.Forms.MenuItem
        Me.MenuItem547 = New System.Windows.Forms.MenuItem
        Me.MenuItem548 = New System.Windows.Forms.MenuItem
        Me.MenuItem549 = New System.Windows.Forms.MenuItem
        Me.MenuItem194 = New System.Windows.Forms.MenuItem
        Me.MenuItem196 = New System.Windows.Forms.MenuItem
        Me.MenuItem197 = New System.Windows.Forms.MenuItem
        Me.MenuItem244 = New System.Windows.Forms.MenuItem
        Me.MenuItem198 = New System.Windows.Forms.MenuItem
        Me.MenuItem199 = New System.Windows.Forms.MenuItem
        Me.MenuItem200 = New System.Windows.Forms.MenuItem
        Me.MenuItem201 = New System.Windows.Forms.MenuItem
        Me.MenuItem210 = New System.Windows.Forms.MenuItem
        Me.MenuItem214 = New System.Windows.Forms.MenuItem
        Me.MenuItem202 = New System.Windows.Forms.MenuItem
        Me.MenuItem203 = New System.Windows.Forms.MenuItem
        Me.MenuItem204 = New System.Windows.Forms.MenuItem
        Me.MenuItem205 = New System.Windows.Forms.MenuItem
        Me.MenuItem206 = New System.Windows.Forms.MenuItem
        Me.MenuItem207 = New System.Windows.Forms.MenuItem
        Me.MenuItem208 = New System.Windows.Forms.MenuItem
        Me.MenuItem209 = New System.Windows.Forms.MenuItem
        Me.MenuItem417 = New System.Windows.Forms.MenuItem
        Me.MenuItem418 = New System.Windows.Forms.MenuItem
        Me.MenuItem490 = New System.Windows.Forms.MenuItem
        Me.MenuItem491 = New System.Windows.Forms.MenuItem
        Me.MenuItem492 = New System.Windows.Forms.MenuItem
        Me.MenuItem493 = New System.Windows.Forms.MenuItem
        Me.MenuItem494 = New System.Windows.Forms.MenuItem
        Me.MenuItem495 = New System.Windows.Forms.MenuItem
        Me.MenuItem496 = New System.Windows.Forms.MenuItem
        Me.MenuItem497 = New System.Windows.Forms.MenuItem
        Me.MenuItem509 = New System.Windows.Forms.MenuItem
        Me.MenuItem508 = New System.Windows.Forms.MenuItem
        Me.MenuItem510 = New System.Windows.Forms.MenuItem
        Me.MenuItem511 = New System.Windows.Forms.MenuItem
        Me.MenuItem561 = New System.Windows.Forms.MenuItem
        Me.MenuItem562 = New System.Windows.Forms.MenuItem
        Me.MenuItem563 = New System.Windows.Forms.MenuItem
        Me.MenuItem565 = New System.Windows.Forms.MenuItem
        Me.MenuItem564 = New System.Windows.Forms.MenuItem
        Me.MenuItem517 = New System.Windows.Forms.MenuItem
        Me.MenuItem518 = New System.Windows.Forms.MenuItem
        Me.MenuItem519 = New System.Windows.Forms.MenuItem
        Me.MenuItem520 = New System.Windows.Forms.MenuItem
        Me.MenuItem521 = New System.Windows.Forms.MenuItem
        Me.MenuItem522 = New System.Windows.Forms.MenuItem
        Me.MenuItem523 = New System.Windows.Forms.MenuItem
        Me.MenuItem524 = New System.Windows.Forms.MenuItem
        Me.MenuItem130 = New System.Windows.Forms.MenuItem
        Me.MenuItem131 = New System.Windows.Forms.MenuItem
        Me.nom = New System.Windows.Forms.MainMenu
        Me.MenuItem132 = New System.Windows.Forms.MenuItem
        Me.MenuItem340 = New System.Windows.Forms.MenuItem
        Me.MenuItem344 = New System.Windows.Forms.MenuItem
        Me.MenuItem345 = New System.Windows.Forms.MenuItem
        Me.MenuItem346 = New System.Windows.Forms.MenuItem
        Me.MenuItem347 = New System.Windows.Forms.MenuItem
        Me.MenuItem356 = New System.Windows.Forms.MenuItem
        Me.MenuItem357 = New System.Windows.Forms.MenuItem
        Me.MenuItem358 = New System.Windows.Forms.MenuItem
        Me.MenuItem355 = New System.Windows.Forms.MenuItem
        Me.MenuItem360 = New System.Windows.Forms.MenuItem
        Me.MenuItem353 = New System.Windows.Forms.MenuItem
        Me.MenuItem359 = New System.Windows.Forms.MenuItem
        Me.MenuItem361 = New System.Windows.Forms.MenuItem
        Me.MenuItem396 = New System.Windows.Forms.MenuItem
        Me.MenuItem397 = New System.Windows.Forms.MenuItem
        Me.MenuItem398 = New System.Windows.Forms.MenuItem
        Me.MenuItem399 = New System.Windows.Forms.MenuItem
        Me.MenuItem400 = New System.Windows.Forms.MenuItem
        Me.MenuItem570 = New System.Windows.Forms.MenuItem
        Me.MenuItem354 = New System.Windows.Forms.MenuItem
        Me.MenuItem365 = New System.Windows.Forms.MenuItem
        Me.MenuItem366 = New System.Windows.Forms.MenuItem
        Me.MenuItem364 = New System.Windows.Forms.MenuItem
        Me.MenuItem401 = New System.Windows.Forms.MenuItem
        Me.MenuItem402 = New System.Windows.Forms.MenuItem
        Me.MenuItem403 = New System.Windows.Forms.MenuItem
        Me.MenuItem404 = New System.Windows.Forms.MenuItem
        Me.MenuItem405 = New System.Windows.Forms.MenuItem
        Me.MenuItem133 = New System.Windows.Forms.MenuItem
        Me.MenuItem370 = New System.Windows.Forms.MenuItem
        Me.MenuItem371 = New System.Windows.Forms.MenuItem
        Me.MenuItem372 = New System.Windows.Forms.MenuItem
        Me.MenuItem394 = New System.Windows.Forms.MenuItem
        Me.MenuItem480 = New System.Windows.Forms.MenuItem
        Me.MenuItem367 = New System.Windows.Forms.MenuItem
        Me.MenuItem411 = New System.Windows.Forms.MenuItem
        Me.MenuItem571 = New System.Windows.Forms.MenuItem
        Me.MenuItem140 = New System.Windows.Forms.MenuItem
        Me.MenuItem378 = New System.Windows.Forms.MenuItem
        Me.MenuItem379 = New System.Windows.Forms.MenuItem
        Me.MenuItem380 = New System.Windows.Forms.MenuItem
        Me.MenuItem381 = New System.Windows.Forms.MenuItem
        Me.MenuItem382 = New System.Windows.Forms.MenuItem
        Me.MenuItem383 = New System.Windows.Forms.MenuItem
        Me.MenuItem384 = New System.Windows.Forms.MenuItem
        Me.MenuItem385 = New System.Windows.Forms.MenuItem
        Me.MenuItem386 = New System.Windows.Forms.MenuItem
        Me.MenuItem387 = New System.Windows.Forms.MenuItem
        Me.MenuItem388 = New System.Windows.Forms.MenuItem
        Me.MenuItem389 = New System.Windows.Forms.MenuItem
        Me.MenuItem390 = New System.Windows.Forms.MenuItem
        Me.MenuItem391 = New System.Windows.Forms.MenuItem
        Me.MenuItem392 = New System.Windows.Forms.MenuItem
        Me.MenuItem412 = New System.Windows.Forms.MenuItem
        Me.MenuItem413 = New System.Windows.Forms.MenuItem
        Me.MenuItem373 = New System.Windows.Forms.MenuItem
        Me.MenuItem374 = New System.Windows.Forms.MenuItem
        Me.MenuItem375 = New System.Windows.Forms.MenuItem
        Me.MenuItem395 = New System.Windows.Forms.MenuItem
        Me.MenuItem143 = New System.Windows.Forms.MenuItem
        Me.MenuItem147 = New System.Windows.Forms.MenuItem
        Me.ban = New System.Windows.Forms.MainMenu
        Me.MenuItem170 = New System.Windows.Forms.MenuItem
        Me.MenuItem211 = New System.Windows.Forms.MenuItem
        Me.MenuItem212 = New System.Windows.Forms.MenuItem
        Me.MenuItem213 = New System.Windows.Forms.MenuItem
        Me.MenuItem215 = New System.Windows.Forms.MenuItem
        Me.MenuItem171 = New System.Windows.Forms.MenuItem
        Me.MenuItem216 = New System.Windows.Forms.MenuItem
        Me.MenuItem217 = New System.Windows.Forms.MenuItem
        Me.MenuItem220 = New System.Windows.Forms.MenuItem
        Me.MenuItem218 = New System.Windows.Forms.MenuItem
        Me.MenuItem525 = New System.Windows.Forms.MenuItem
        Me.MenuItem526 = New System.Windows.Forms.MenuItem
        Me.MenuItem172 = New System.Windows.Forms.MenuItem
        Me.MenuItem221 = New System.Windows.Forms.MenuItem
        Me.MenuItem219 = New System.Windows.Forms.MenuItem
        Me.MenuItem226 = New System.Windows.Forms.MenuItem
        Me.MenuItem227 = New System.Windows.Forms.MenuItem
        Me.MenuItem542 = New System.Windows.Forms.MenuItem
        Me.MenuItem543 = New System.Windows.Forms.MenuItem
        Me.MenuItem222 = New System.Windows.Forms.MenuItem
        Me.MenuItem225 = New System.Windows.Forms.MenuItem
        Me.MenuItem224 = New System.Windows.Forms.MenuItem
        Me.MenuItem223 = New System.Windows.Forms.MenuItem
        Me.MenuItem528 = New System.Windows.Forms.MenuItem
        Me.MenuItem529 = New System.Windows.Forms.MenuItem
        Me.MenuItem173 = New System.Windows.Forms.MenuItem
        Me.MenuItem174 = New System.Windows.Forms.MenuItem
        Me.cnt = New System.Windows.Forms.MainMenu
        Me.MenuItem150 = New System.Windows.Forms.MenuItem
        Me.MenuItem228 = New System.Windows.Forms.MenuItem
        Me.MenuItem229 = New System.Windows.Forms.MenuItem
        Me.MenuItem231 = New System.Windows.Forms.MenuItem
        Me.MenuItem230 = New System.Windows.Forms.MenuItem
        Me.MenuItem166 = New System.Windows.Forms.MenuItem
        Me.MenuItem232 = New System.Windows.Forms.MenuItem
        Me.MenuItem233 = New System.Windows.Forms.MenuItem
        Me.MenuItem234 = New System.Windows.Forms.MenuItem
        Me.MenuItem299 = New System.Windows.Forms.MenuItem
        Me.MenuItem300 = New System.Windows.Forms.MenuItem
        Me.MenuItem301 = New System.Windows.Forms.MenuItem
        Me.MenuItem235 = New System.Windows.Forms.MenuItem
        Me.MenuItem296 = New System.Windows.Forms.MenuItem
        Me.MenuItem297 = New System.Windows.Forms.MenuItem
        Me.MenuItem368 = New System.Windows.Forms.MenuItem
        Me.MenuItem369 = New System.Windows.Forms.MenuItem
        Me.MenuItem167 = New System.Windows.Forms.MenuItem
        Me.MenuItem236 = New System.Windows.Forms.MenuItem
        Me.MenuItem237 = New System.Windows.Forms.MenuItem
        Me.MenuItem238 = New System.Windows.Forms.MenuItem
        Me.MenuItem239 = New System.Windows.Forms.MenuItem
        Me.MenuItem246 = New System.Windows.Forms.MenuItem
        Me.MenuItem247 = New System.Windows.Forms.MenuItem
        Me.MenuItem248 = New System.Windows.Forms.MenuItem
        Me.MenuItem240 = New System.Windows.Forms.MenuItem
        Me.MenuItem241 = New System.Windows.Forms.MenuItem
        Me.MenuItem242 = New System.Windows.Forms.MenuItem
        Me.MenuItem243 = New System.Windows.Forms.MenuItem
        Me.MenuItem245 = New System.Windows.Forms.MenuItem
        Me.MenuItem506 = New System.Windows.Forms.MenuItem
        Me.MenuItem507 = New System.Windows.Forms.MenuItem
        Me.MenuItem532 = New System.Windows.Forms.MenuItem
        Me.MenuItem533 = New System.Windows.Forms.MenuItem
        Me.MenuItem168 = New System.Windows.Forms.MenuItem
        Me.MenuItem169 = New System.Windows.Forms.MenuItem
        Me.act = New System.Windows.Forms.MainMenu
        Me.MenuItem175 = New System.Windows.Forms.MenuItem
        Me.MenuItem302 = New System.Windows.Forms.MenuItem
        Me.MenuItem303 = New System.Windows.Forms.MenuItem
        Me.MenuItem310 = New System.Windows.Forms.MenuItem
        Me.MenuItem304 = New System.Windows.Forms.MenuItem
        Me.MenuItem305 = New System.Windows.Forms.MenuItem
        Me.MenuItem306 = New System.Windows.Forms.MenuItem
        Me.MenuItem307 = New System.Windows.Forms.MenuItem
        Me.MenuItem308 = New System.Windows.Forms.MenuItem
        Me.MenuItem309 = New System.Windows.Forms.MenuItem
        Me.MenuItem176 = New System.Windows.Forms.MenuItem
        Me.MenuItem311 = New System.Windows.Forms.MenuItem
        Me.MenuItem313 = New System.Windows.Forms.MenuItem
        Me.MenuItem314 = New System.Windows.Forms.MenuItem
        Me.MenuItem312 = New System.Windows.Forms.MenuItem
        Me.MenuItem177 = New System.Windows.Forms.MenuItem
        Me.MenuItem315 = New System.Windows.Forms.MenuItem
        Me.MenuItem316 = New System.Windows.Forms.MenuItem
        Me.MenuItem317 = New System.Windows.Forms.MenuItem
        Me.MenuItem322 = New System.Windows.Forms.MenuItem
        Me.MenuItem318 = New System.Windows.Forms.MenuItem
        Me.MenuItem319 = New System.Windows.Forms.MenuItem
        Me.MenuItem320 = New System.Windows.Forms.MenuItem
        Me.MenuItem323 = New System.Windows.Forms.MenuItem
        Me.MenuItem321 = New System.Windows.Forms.MenuItem
        Me.MenuItem178 = New System.Windows.Forms.MenuItem
        Me.MenuItem179 = New System.Windows.Forms.MenuItem
        Me.adm = New System.Windows.Forms.MainMenu
        Me.MenuItem335 = New System.Windows.Forms.MenuItem
        Me.MenuItem336 = New System.Windows.Forms.MenuItem
        Me.MenuItem337 = New System.Windows.Forms.MenuItem
        Me.MenuItem339 = New System.Windows.Forms.MenuItem
        Me.MenuItem342 = New System.Windows.Forms.MenuItem
        Me.MenuItem343 = New System.Windows.Forms.MenuItem
        Me.MenuItem348 = New System.Windows.Forms.MenuItem
        Me.MenuItem349 = New System.Windows.Forms.MenuItem
        Me.MenuItem350 = New System.Windows.Forms.MenuItem
        Me.MenuItem351 = New System.Windows.Forms.MenuItem
        Me.MenuItem352 = New System.Windows.Forms.MenuItem
        Me.MenuItem338 = New System.Windows.Forms.MenuItem
        Me.MenuItem376 = New System.Windows.Forms.MenuItem
        Me.MenuItem534 = New System.Windows.Forms.MenuItem
        Me.MenuItem377 = New System.Windows.Forms.MenuItem
        Me.MenuItem471 = New System.Windows.Forms.MenuItem
        Me.MenuItem472 = New System.Windows.Forms.MenuItem
        Me.MenuItem481 = New System.Windows.Forms.MenuItem
        Me.MenuItem482 = New System.Windows.Forms.MenuItem
        Me.MenuItem576 = New System.Windows.Forms.MenuItem
        Me.MenuItem577 = New System.Windows.Forms.MenuItem
        Me.MenuItem341 = New System.Windows.Forms.MenuItem
        Me.Pentra = New System.Windows.Forms.ProgressBar
        Me.ani = New System.Windows.Forms.MainMenu
        Me.MenuItem419 = New System.Windows.Forms.MenuItem
        Me.MenuItem420 = New System.Windows.Forms.MenuItem
        Me.MenuItem421 = New System.Windows.Forms.MenuItem
        Me.MenuItem422 = New System.Windows.Forms.MenuItem
        Me.MenuItem423 = New System.Windows.Forms.MenuItem
        Me.MenuItem424 = New System.Windows.Forms.MenuItem
        Me.MenuItem425 = New System.Windows.Forms.MenuItem
        Me.MenuItem426 = New System.Windows.Forms.MenuItem
        Me.MenuItem427 = New System.Windows.Forms.MenuItem
        Me.MenuItem428 = New System.Windows.Forms.MenuItem
        Me.MenuItem429 = New System.Windows.Forms.MenuItem
        Me.MenuItem431 = New System.Windows.Forms.MenuItem
        Me.MenuItem434 = New System.Windows.Forms.MenuItem
        Me.MenuItem435 = New System.Windows.Forms.MenuItem
        Me.MenuItem437 = New System.Windows.Forms.MenuItem
        Me.MenuItem441 = New System.Windows.Forms.MenuItem
        Me.MenuItem439 = New System.Windows.Forms.MenuItem
        Me.MenuItem430 = New System.Windows.Forms.MenuItem
        Me.MenuItem433 = New System.Windows.Forms.MenuItem
        Me.MenuItem436 = New System.Windows.Forms.MenuItem
        Me.MenuItem473 = New System.Windows.Forms.MenuItem
        Me.MenuItem474 = New System.Windows.Forms.MenuItem
        Me.MenuItem432 = New System.Windows.Forms.MenuItem
        Me.MenuItem438 = New System.Windows.Forms.MenuItem
        Me.MenuItem452 = New System.Windows.Forms.MenuItem
        Me.MenuItem442 = New System.Windows.Forms.MenuItem
        Me.MenuItem444 = New System.Windows.Forms.MenuItem
        Me.MenuItem451 = New System.Windows.Forms.MenuItem
        Me.MenuItem445 = New System.Windows.Forms.MenuItem
        Me.MenuItem446 = New System.Windows.Forms.MenuItem
        Me.MenuItem443 = New System.Windows.Forms.MenuItem
        Me.MenuItem447 = New System.Windows.Forms.MenuItem
        Me.MenuItem450 = New System.Windows.Forms.MenuItem
        Me.MenuItem448 = New System.Windows.Forms.MenuItem
        Me.MenuItem449 = New System.Windows.Forms.MenuItem
        Me.MenuItem453 = New System.Windows.Forms.MenuItem
        Me.MenuItem470 = New System.Windows.Forms.MenuItem
        Me.MenuItem498 = New System.Windows.Forms.MenuItem
        Me.MenuItem499 = New System.Windows.Forms.MenuItem
        Me.MenuItem502 = New System.Windows.Forms.MenuItem
        Me.MenuItem505 = New System.Windows.Forms.MenuItem
        Me.MenuItem440 = New System.Windows.Forms.MenuItem
        Me.MenuItem454 = New System.Windows.Forms.MenuItem
        Me.MenuItem458 = New System.Windows.Forms.MenuItem
        Me.MenuItem455 = New System.Windows.Forms.MenuItem
        Me.MenuItem460 = New System.Windows.Forms.MenuItem
        Me.MenuItem464 = New System.Windows.Forms.MenuItem
        Me.MenuItem461 = New System.Windows.Forms.MenuItem
        Me.MenuItem462 = New System.Windows.Forms.MenuItem
        Me.MenuItem463 = New System.Windows.Forms.MenuItem
        Me.MenuItem456 = New System.Windows.Forms.MenuItem
        Me.MenuItem465 = New System.Windows.Forms.MenuItem
        Me.MenuItem469 = New System.Windows.Forms.MenuItem
        Me.MenuItem466 = New System.Windows.Forms.MenuItem
        Me.MenuItem467 = New System.Windows.Forms.MenuItem
        Me.MenuItem468 = New System.Windows.Forms.MenuItem
        Me.MenuItem459 = New System.Windows.Forms.MenuItem
        Me.MenuItem457 = New System.Windows.Forms.MenuItem
        Me.MenuItem475 = New System.Windows.Forms.MenuItem
        Me.MenuItem476 = New System.Windows.Forms.MenuItem
        Me.MenuItem500 = New System.Windows.Forms.MenuItem
        Me.MenuItem501 = New System.Windows.Forms.MenuItem
        Me.MenuItem503 = New System.Windows.Forms.MenuItem
        Me.MenuItem504 = New System.Windows.Forms.MenuItem
        Me.tab1.SuspendLayout()
        CType(Me.p1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.p2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tab1
        '
        Me.tab1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tab1.Controls.Add(Me.ainv)
        Me.tab1.Controls.Add(Me.acxc)
        Me.tab1.Controls.Add(Me.anom)
        Me.tab1.Controls.Add(Me.aban)
        Me.tab1.Controls.Add(Me.aact)
        Me.tab1.Controls.Add(Me.acxp)
        Me.tab1.Controls.Add(Me.afac)
        Me.tab1.Controls.Add(Me.acnt)
        Me.tab1.Controls.Add(Me.aani)
        Me.tab1.Controls.Add(Me.aadm)
        Me.tab1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tab1.Location = New System.Drawing.Point(0, 0)
        Me.tab1.Name = "tab1"
        Me.tab1.SelectedIndex = 0
        Me.tab1.Size = New System.Drawing.Size(1038, 24)
        Me.tab1.TabIndex = 2
        '
        'ainv
        '
        Me.ainv.AccessibleName = "inv"
        Me.ainv.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ainv.ImageIndex = 8
        Me.ainv.Location = New System.Drawing.Point(4, 25)
        Me.ainv.Name = "ainv"
        Me.ainv.Size = New System.Drawing.Size(1030, 0)
        Me.ainv.TabIndex = 1
        Me.ainv.Text = "Inventario"
        Me.ainv.Visible = False
        '
        'acxc
        '
        Me.acxc.AccessibleName = "cxc"
        Me.acxc.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar
        Me.acxc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.acxc.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acxc.ImageIndex = 1
        Me.acxc.Location = New System.Drawing.Point(4, 25)
        Me.acxc.Name = "acxc"
        Me.acxc.Size = New System.Drawing.Size(1030, -5)
        Me.acxc.TabIndex = 0
        Me.acxc.Text = "Cuentas por Cobrar"
        '
        'anom
        '
        Me.anom.AccessibleName = "nom"
        Me.anom.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.anom.ImageIndex = 15
        Me.anom.Location = New System.Drawing.Point(4, 25)
        Me.anom.Name = "anom"
        Me.anom.Size = New System.Drawing.Size(1030, -5)
        Me.anom.TabIndex = 3
        Me.anom.Text = "N�mina"
        Me.anom.Visible = False
        '
        'aban
        '
        Me.aban.AccessibleName = "ban"
        Me.aban.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aban.ImageIndex = 14
        Me.aban.Location = New System.Drawing.Point(4, 25)
        Me.aban.Name = "aban"
        Me.aban.Size = New System.Drawing.Size(1030, -5)
        Me.aban.TabIndex = 6
        Me.aban.Text = "Bancos"
        Me.aban.Visible = False
        '
        'aact
        '
        Me.aact.AccessibleName = "act"
        Me.aact.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aact.ImageIndex = 17
        Me.aact.Location = New System.Drawing.Point(4, 25)
        Me.aact.Name = "aact"
        Me.aact.Size = New System.Drawing.Size(1030, -5)
        Me.aact.TabIndex = 7
        Me.aact.Text = "Activos Fijos"
        Me.aact.Visible = False
        '
        'acxp
        '
        Me.acxp.AccessibleName = "cxp"
        Me.acxp.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acxp.ImageIndex = 2
        Me.acxp.Location = New System.Drawing.Point(4, 25)
        Me.acxp.Name = "acxp"
        Me.acxp.Size = New System.Drawing.Size(1030, 0)
        Me.acxp.TabIndex = 4
        Me.acxp.Text = "Cuentas por Pagar"
        Me.acxp.Visible = False
        '
        'afac
        '
        Me.afac.AccessibleName = "fac"
        Me.afac.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.afac.ImageIndex = 13
        Me.afac.Location = New System.Drawing.Point(4, 25)
        Me.afac.Name = "afac"
        Me.afac.Size = New System.Drawing.Size(1030, -5)
        Me.afac.TabIndex = 2
        Me.afac.Text = "Facturaci�n"
        Me.afac.Visible = False
        '
        'acnt
        '
        Me.acnt.AccessibleName = "cnt"
        Me.acnt.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.acnt.ImageIndex = 3
        Me.acnt.Location = New System.Drawing.Point(4, 25)
        Me.acnt.Name = "acnt"
        Me.acnt.Size = New System.Drawing.Size(1030, -5)
        Me.acnt.TabIndex = 5
        Me.acnt.Text = "Contabilidad"
        Me.acnt.Visible = False
        '
        'aani
        '
        Me.aani.AccessibleName = "ani"
        Me.aani.ImageIndex = 4
        Me.aani.Location = New System.Drawing.Point(4, 25)
        Me.aani.Name = "aani"
        Me.aani.Size = New System.Drawing.Size(1030, -5)
        Me.aani.TabIndex = 9
        Me.aani.Text = "Control Animales"
        '
        'aadm
        '
        Me.aadm.AccessibleName = "adm"
        Me.aadm.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aadm.ImageIndex = 10
        Me.aadm.Location = New System.Drawing.Point(4, 25)
        Me.aadm.Name = "aadm"
        Me.aadm.Size = New System.Drawing.Size(1030, -5)
        Me.aadm.TabIndex = 8
        Me.aadm.Text = "Administrador"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = -1
        Me.MenuItem7.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem9, Me.MenuItem10, Me.MenuItem107, Me.MenuItem104, Me.MenuItem106, Me.MenuItem108, Me.MenuItem126, Me.MenuItem105})
        Me.MenuItem7.Text = "&Registrar"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 0
        Me.MenuItem9.Text = "&1.- Zonas de Operaci�n"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 1
        Me.MenuItem10.Text = "&2.- Sucursales"
        '
        'MenuItem107
        '
        Me.MenuItem107.Index = 2
        Me.MenuItem107.Text = "-"
        '
        'MenuItem104
        '
        Me.MenuItem104.Index = 3
        Me.MenuItem104.Text = "&3.- Condiciones de Pago"
        '
        'MenuItem106
        '
        Me.MenuItem106.Index = 4
        Me.MenuItem106.Text = "&4.- Departamentos"
        '
        'MenuItem108
        '
        Me.MenuItem108.Index = 5
        Me.MenuItem108.Text = "-"
        '
        'MenuItem126
        '
        Me.MenuItem126.Index = 6
        Me.MenuItem126.Text = "&5.- Tipos de Suplidores"
        '
        'MenuItem105
        '
        Me.MenuItem105.Index = 7
        Me.MenuItem105.Text = "&6.- Suplidores"
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = -1
        Me.MenuItem8.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem11, Me.MenuItem112, Me.MenuItem109, Me.MenuItem110, Me.MenuItem113, Me.MenuItem111})
        Me.MenuItem8.Text = "&Procesos"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 0
        Me.MenuItem11.Text = "&1.- Facturas por Pagar"
        '
        'MenuItem112
        '
        Me.MenuItem112.Index = 1
        Me.MenuItem112.Text = "-"
        '
        'MenuItem109
        '
        Me.MenuItem109.Index = 2
        Me.MenuItem109.Text = "&2.- Pagos a Facturas"
        '
        'MenuItem110
        '
        Me.MenuItem110.Index = 3
        Me.MenuItem110.Text = "&3.- Notas D�bito/Cr�dito"
        '
        'MenuItem113
        '
        Me.MenuItem113.Index = 4
        Me.MenuItem113.Text = "-"
        '
        'MenuItem111
        '
        Me.MenuItem111.Index = 5
        Me.MenuItem111.Text = "&4.- Anticipos a Facturas"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = -1
        Me.MenuItem50.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem114, Me.MenuItem115, Me.MenuItem116, Me.MenuItem117, Me.MenuItem118, Me.MenuItem122, Me.MenuItem123, Me.MenuItem135, Me.MenuItem136})
        Me.MenuItem50.Text = "Re&portes/Consultas"
        '
        'MenuItem114
        '
        Me.MenuItem114.Index = 0
        Me.MenuItem114.Text = "&1.- Relaci�n de Suplidores"
        '
        'MenuItem115
        '
        Me.MenuItem115.Index = 1
        Me.MenuItem115.Text = "&2.- Balance Cuentas por Pagar"
        '
        'MenuItem116
        '
        Me.MenuItem116.Index = 2
        Me.MenuItem116.Text = "-"
        '
        'MenuItem117
        '
        Me.MenuItem117.Index = 3
        Me.MenuItem117.Text = "&3.- Facturas por Pagar"
        '
        'MenuItem118
        '
        Me.MenuItem118.Index = 4
        Me.MenuItem118.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem119, Me.MenuItem120, Me.MenuItem121})
        Me.MenuItem118.Text = "&4.- Pagos a Suplidres"
        '
        'MenuItem119
        '
        Me.MenuItem119.Index = 0
        Me.MenuItem119.Text = "&1.- Pagos Detallados"
        '
        'MenuItem120
        '
        Me.MenuItem120.Index = 1
        Me.MenuItem120.Text = "-"
        '
        'MenuItem121
        '
        Me.MenuItem121.Index = 2
        Me.MenuItem121.Text = "&2.- Pagos Totalizados"
        '
        'MenuItem122
        '
        Me.MenuItem122.Index = 5
        Me.MenuItem122.Text = "-"
        '
        'MenuItem123
        '
        Me.MenuItem123.Index = 6
        Me.MenuItem123.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem125, Me.MenuItem124, Me.MenuItem134})
        Me.MenuItem123.Text = "&5.- Otros Reportes"
        '
        'MenuItem125
        '
        Me.MenuItem125.Index = 0
        Me.MenuItem125.Text = "&1.- Condiciones de Pago"
        '
        'MenuItem124
        '
        Me.MenuItem124.Index = 1
        Me.MenuItem124.Text = "-"
        '
        'MenuItem134
        '
        Me.MenuItem134.Index = 2
        Me.MenuItem134.Text = "&2.- Tipos de Suplidores"
        '
        'MenuItem135
        '
        Me.MenuItem135.Index = 7
        Me.MenuItem135.Text = "-"
        '
        'MenuItem136
        '
        Me.MenuItem136.Index = 8
        Me.MenuItem136.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem137, Me.MenuItem151, Me.MenuItem152, Me.MenuItem156, Me.MenuItem160, Me.MenuItem161, Me.MenuItem165, Me.MenuItem289, Me.MenuItem292, Me.MenuItem551})
        Me.MenuItem136.Text = "&6.- An�lisis Cuentas por Pagar"
        '
        'MenuItem137
        '
        Me.MenuItem137.Index = 0
        Me.MenuItem137.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem138, Me.MenuItem144, Me.MenuItem145, Me.MenuItem290, Me.MenuItem291, Me.MenuItem540, Me.MenuItem541})
        Me.MenuItem137.Text = "&1.- Relaci�n de Compras"
        '
        'MenuItem138
        '
        Me.MenuItem138.Index = 0
        Me.MenuItem138.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem139, Me.MenuItem141, Me.MenuItem142})
        Me.MenuItem138.Text = "&1.- Compras Detalladas"
        '
        'MenuItem139
        '
        Me.MenuItem139.Index = 0
        Me.MenuItem139.Text = "&1.-Suplidores"
        '
        'MenuItem141
        '
        Me.MenuItem141.Index = 1
        Me.MenuItem141.Text = "&2.- Zonas"
        '
        'MenuItem142
        '
        Me.MenuItem142.Index = 2
        Me.MenuItem142.Text = "&3.- Sucursales"
        '
        'MenuItem144
        '
        Me.MenuItem144.Index = 1
        Me.MenuItem144.Text = "-"
        '
        'MenuItem145
        '
        Me.MenuItem145.Index = 2
        Me.MenuItem145.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem146, Me.MenuItem148, Me.MenuItem149})
        Me.MenuItem145.Text = "&2.- Compras Totalizadas"
        '
        'MenuItem146
        '
        Me.MenuItem146.Index = 0
        Me.MenuItem146.Text = "&1.- Suplidores"
        '
        'MenuItem148
        '
        Me.MenuItem148.Index = 1
        Me.MenuItem148.Text = "&2.- Zonas"
        '
        'MenuItem149
        '
        Me.MenuItem149.Index = 2
        Me.MenuItem149.Text = "&3.- Sucursales"
        '
        'MenuItem290
        '
        Me.MenuItem290.Index = 3
        Me.MenuItem290.Text = "-"
        '
        'MenuItem291
        '
        Me.MenuItem291.Index = 4
        Me.MenuItem291.Text = "3.- Relaci�n de Compras"
        '
        'MenuItem540
        '
        Me.MenuItem540.Index = 5
        Me.MenuItem540.Text = "-"
        '
        'MenuItem541
        '
        Me.MenuItem541.Index = 6
        Me.MenuItem541.Text = "&4.- Otras Retenciones"
        '
        'MenuItem151
        '
        Me.MenuItem151.Index = 1
        Me.MenuItem151.Text = "-"
        '
        'MenuItem152
        '
        Me.MenuItem152.Index = 2
        Me.MenuItem152.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem153, Me.MenuItem154, Me.MenuItem155})
        Me.MenuItem152.Text = "&2.- Relaci�n de Notas"
        '
        'MenuItem153
        '
        Me.MenuItem153.Index = 0
        Me.MenuItem153.Text = "&1.- Notas Detalladas "
        '
        'MenuItem154
        '
        Me.MenuItem154.Index = 1
        Me.MenuItem154.Text = "-"
        '
        'MenuItem155
        '
        Me.MenuItem155.Index = 2
        Me.MenuItem155.Text = "&2.- Notas Totalizadas"
        '
        'MenuItem156
        '
        Me.MenuItem156.Index = 3
        Me.MenuItem156.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem157, Me.MenuItem158, Me.MenuItem159})
        Me.MenuItem156.Text = "&3.- Relaci�n de Anticipos"
        '
        'MenuItem157
        '
        Me.MenuItem157.Index = 0
        Me.MenuItem157.Text = "&1.- Anticipos Detallados"
        '
        'MenuItem158
        '
        Me.MenuItem158.Index = 1
        Me.MenuItem158.Text = "-"
        '
        'MenuItem159
        '
        Me.MenuItem159.Index = 2
        Me.MenuItem159.Text = "&2.- Anticipos Aplicados"
        '
        'MenuItem160
        '
        Me.MenuItem160.Index = 4
        Me.MenuItem160.Text = "-"
        '
        'MenuItem161
        '
        Me.MenuItem161.Index = 5
        Me.MenuItem161.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem283, Me.MenuItem284, Me.MenuItem285})
        Me.MenuItem161.Text = "&4.- Antiguedad de Saldos"
        '
        'MenuItem283
        '
        Me.MenuItem283.Index = 0
        Me.MenuItem283.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem286, Me.MenuItem287, Me.MenuItem288})
        Me.MenuItem283.Text = "1.- Actual"
        '
        'MenuItem286
        '
        Me.MenuItem286.Index = 0
        Me.MenuItem286.Text = "&1.- Dias Transcurridos"
        '
        'MenuItem287
        '
        Me.MenuItem287.Index = 1
        Me.MenuItem287.Text = "-"
        '
        'MenuItem288
        '
        Me.MenuItem288.Index = 2
        Me.MenuItem288.Text = "&2.- Dias Vencidos"
        '
        'MenuItem284
        '
        Me.MenuItem284.Index = 1
        Me.MenuItem284.Text = "-"
        '
        'MenuItem285
        '
        Me.MenuItem285.Index = 2
        Me.MenuItem285.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem162, Me.MenuItem163, Me.MenuItem164})
        Me.MenuItem285.Text = "&2.- Rango de Fecha"
        '
        'MenuItem162
        '
        Me.MenuItem162.Index = 0
        Me.MenuItem162.Text = "&1.- Dias Transcurridos"
        '
        'MenuItem163
        '
        Me.MenuItem163.Index = 1
        Me.MenuItem163.Text = "-"
        '
        'MenuItem164
        '
        Me.MenuItem164.Index = 2
        Me.MenuItem164.Text = "&2.- Dias Vencidos"
        '
        'MenuItem165
        '
        Me.MenuItem165.Index = 6
        Me.MenuItem165.Text = "&5.- Historial de Movimientos"
        '
        'MenuItem289
        '
        Me.MenuItem289.Index = 7
        Me.MenuItem289.Text = "-"
        '
        'MenuItem292
        '
        Me.MenuItem292.Index = 8
        Me.MenuItem292.Text = "&6.- Balances a una Fecha"
        '
        'MenuItem551
        '
        Me.MenuItem551.Index = 9
        Me.MenuItem551.Text = "&7.- Balances por Facturas"
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = -1
        Me.MenuItem54.Text = "&Ayuda"
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = -1
        Me.MenuItem55.Text = "&Salida"
        '
        'cxc
        '
        Me.cxc.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem12, Me.MenuItem14, Me.MenuItem15})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem17, Me.MenuItem20, Me.MenuItem4, Me.MenuItem33, Me.MenuItem16, Me.MenuItem18, Me.MenuItem21, Me.MenuItem19, Me.MenuItem35, Me.MenuItem31, Me.MenuItem32})
        Me.MenuItem1.Text = "&Registrar"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.Text = "&1.- Zonas de Operaciones"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 1
        Me.MenuItem17.Text = "&2.- Sucursales"
        '
        'MenuItem20
        '
        Me.MenuItem20.Index = 2
        Me.MenuItem20.Text = "&3.- Tipos de Vendedores"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 3
        Me.MenuItem4.Text = "&4.- Rango Comisiones"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 4
        Me.MenuItem33.Text = "&5.- Vendedores"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 5
        Me.MenuItem16.Text = "-"
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 6
        Me.MenuItem18.Text = "&6.- Condiciones de Pago"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 7
        Me.MenuItem21.Text = "&7.- Tipos de Clientes"
        '
        'MenuItem19
        '
        Me.MenuItem19.Index = 8
        Me.MenuItem19.Text = "&8.- Tipos de Envios"
        '
        'MenuItem35
        '
        Me.MenuItem35.Index = 9
        Me.MenuItem35.Text = "&9.- Tipos de Servicios"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 10
        Me.MenuItem31.Text = "-"
        '
        'MenuItem32
        '
        Me.MenuItem32.Index = 11
        Me.MenuItem32.Text = "&0.- Datos de Clientes"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem5, Me.MenuItem6, Me.MenuItem36, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem40})
        Me.MenuItem2.Text = "&Procesos"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 0
        Me.MenuItem5.Text = "&1.- Facturas de Servicios"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "&2.- Facturas por lotes"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 2
        Me.MenuItem36.Text = "-"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 3
        Me.MenuItem37.Text = "&3.- Pagos a Facturas"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 4
        Me.MenuItem38.Text = "&4.- Notas D�bito/Cr�dito"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 5
        Me.MenuItem39.Text = "-"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 6
        Me.MenuItem40.Text = "&5.- Avances a Facturas"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 2
        Me.MenuItem12.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem41, Me.MenuItem42, Me.MenuItem43, Me.MenuItem49, Me.MenuItem52, Me.MenuItem53, Me.MenuItem56, Me.MenuItem51, Me.MenuItem68})
        Me.MenuItem12.Text = "Re&portes/Consultas"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 0
        Me.MenuItem41.Text = "&1.- Relaci�n de Clientes"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 1
        Me.MenuItem42.Text = "&2.- Balance Actuales"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 2
        Me.MenuItem43.Text = "-"
        '
        'MenuItem49
        '
        Me.MenuItem49.Index = 3
        Me.MenuItem49.Text = "&3.- Facturas Pendientes"
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 4
        Me.MenuItem52.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem92, Me.MenuItem93, Me.MenuItem94})
        Me.MenuItem52.Text = "&4.- Pagos de Clientes"
        '
        'MenuItem92
        '
        Me.MenuItem92.Index = 0
        Me.MenuItem92.Text = "&1.- Pagos Detallados"
        '
        'MenuItem93
        '
        Me.MenuItem93.Index = 1
        Me.MenuItem93.Text = "-"
        '
        'MenuItem94
        '
        Me.MenuItem94.Index = 2
        Me.MenuItem94.Text = "&2.- Pagos Totalizados"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 5
        Me.MenuItem53.Text = "-"
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 6
        Me.MenuItem56.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem57, Me.MenuItem58, Me.MenuItem65, Me.MenuItem59, Me.MenuItem60, Me.MenuItem61, Me.MenuItem66, Me.MenuItem62, Me.MenuItem63, Me.MenuItem67, Me.MenuItem64})
        Me.MenuItem56.Text = "&5.- Otros Reportes"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 0
        Me.MenuItem57.Text = "&1.- Vendedores"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 1
        Me.MenuItem58.Text = "&2.- Zonas"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 2
        Me.MenuItem65.Text = "-"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 3
        Me.MenuItem59.Text = "&3.- Servicios"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 4
        Me.MenuItem60.Text = "&4.- Tipos Clientes"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 5
        Me.MenuItem61.Text = "&5.- Tipos Vendedores"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 6
        Me.MenuItem66.Text = "-"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 7
        Me.MenuItem62.Text = "&6.- Tipos de Envios"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 8
        Me.MenuItem63.Text = "&7.- Rango Comisiones "
        '
        'MenuItem67
        '
        Me.MenuItem67.Index = 9
        Me.MenuItem67.Text = "-"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 10
        Me.MenuItem64.Text = "&8.- Sucursales"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 7
        Me.MenuItem51.Text = "-"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 8
        Me.MenuItem68.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem69, Me.MenuItem76, Me.MenuItem86, Me.MenuItem87, Me.MenuItem84, Me.MenuItem85, Me.MenuItem95, Me.MenuItem293, Me.MenuItem294, Me.MenuItem550, Me.MenuItem409, Me.MenuItem410})
        Me.MenuItem68.Text = "&6.- An�lisis Cuentas por Cobrar"
        '
        'MenuItem69
        '
        Me.MenuItem69.Index = 0
        Me.MenuItem69.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem73, Me.MenuItem77, Me.MenuItem78})
        Me.MenuItem69.Text = "&1.- Relaci�n de Ventas"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 0
        Me.MenuItem73.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem70, Me.MenuItem71, Me.MenuItem72, Me.MenuItem74, Me.MenuItem75})
        Me.MenuItem73.Text = "&1.- Ventas Detalladas"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 0
        Me.MenuItem70.Text = "&1.- Clientes"
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 1
        Me.MenuItem71.Text = "&2.- Vendedores"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 2
        Me.MenuItem72.Text = "&3.- Zonas"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 3
        Me.MenuItem74.Text = "&4.- Sucursales"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 4
        Me.MenuItem75.Text = "&5.- Tipos de Facturas"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 1
        Me.MenuItem77.Text = "-"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 2
        Me.MenuItem78.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem79, Me.MenuItem80, Me.MenuItem81, Me.MenuItem82, Me.MenuItem83})
        Me.MenuItem78.Text = "&2.- Ventas Totalizadas"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 0
        Me.MenuItem79.Text = "&1.- Clientes"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 1
        Me.MenuItem80.Text = "&2.- Vendedores"
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 2
        Me.MenuItem81.Text = "&3.- Zonas"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 3
        Me.MenuItem82.Text = "&4.- Sucursales"
        '
        'MenuItem83
        '
        Me.MenuItem83.Index = 4
        Me.MenuItem83.Text = "&5.- Tipos de Facturas"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 1
        Me.MenuItem76.Text = "-"
        '
        'MenuItem86
        '
        Me.MenuItem86.Index = 2
        Me.MenuItem86.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem13, Me.MenuItem96, Me.MenuItem97})
        Me.MenuItem86.Text = "&2.- Relaci�n de Notas"
        '
        'MenuItem13
        '
        Me.MenuItem13.Index = 0
        Me.MenuItem13.Text = "&1.- Notas Detalladas "
        '
        'MenuItem96
        '
        Me.MenuItem96.Index = 1
        Me.MenuItem96.Text = "-"
        '
        'MenuItem97
        '
        Me.MenuItem97.Index = 2
        Me.MenuItem97.Text = "&2.- Notas Totalizadas"
        '
        'MenuItem87
        '
        Me.MenuItem87.Index = 3
        Me.MenuItem87.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem98, Me.MenuItem99, Me.MenuItem100})
        Me.MenuItem87.Text = "&3.- Relaci�n de Anticipos"
        '
        'MenuItem98
        '
        Me.MenuItem98.Index = 0
        Me.MenuItem98.Text = "&1.- Anticipos Detallados"
        '
        'MenuItem99
        '
        Me.MenuItem99.Index = 1
        Me.MenuItem99.Text = "-"
        '
        'MenuItem100
        '
        Me.MenuItem100.Index = 2
        Me.MenuItem100.Text = "&2.- Anticipos Aplicados"
        '
        'MenuItem84
        '
        Me.MenuItem84.Index = 4
        Me.MenuItem84.Text = "-"
        '
        'MenuItem85
        '
        Me.MenuItem85.Index = 5
        Me.MenuItem85.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem102, Me.MenuItem278, Me.MenuItem277})
        Me.MenuItem85.Text = "&4.- Antiguedad de Saldos"
        '
        'MenuItem102
        '
        Me.MenuItem102.Index = 0
        Me.MenuItem102.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem280, Me.MenuItem281, Me.MenuItem282})
        Me.MenuItem102.Text = "&1.- Actual"
        '
        'MenuItem280
        '
        Me.MenuItem280.Index = 0
        Me.MenuItem280.Text = "&1.- Dias Transcurridos"
        '
        'MenuItem281
        '
        Me.MenuItem281.Index = 1
        Me.MenuItem281.Text = "-"
        '
        'MenuItem282
        '
        Me.MenuItem282.Index = 2
        Me.MenuItem282.Text = "&2.- Dias Vencidos"
        '
        'MenuItem278
        '
        Me.MenuItem278.Index = 1
        Me.MenuItem278.Text = "-"
        '
        'MenuItem277
        '
        Me.MenuItem277.Index = 2
        Me.MenuItem277.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem101, Me.MenuItem279, Me.MenuItem103})
        Me.MenuItem277.Text = "&2.- Rango de Fecha"
        '
        'MenuItem101
        '
        Me.MenuItem101.Index = 0
        Me.MenuItem101.Text = "&1.- Dias Transcurridos"
        '
        'MenuItem279
        '
        Me.MenuItem279.Index = 1
        Me.MenuItem279.Text = "-"
        '
        'MenuItem103
        '
        Me.MenuItem103.Index = 2
        Me.MenuItem103.Text = "&2.- Dias Vencidos"
        '
        'MenuItem95
        '
        Me.MenuItem95.Index = 6
        Me.MenuItem95.Text = "&5.- Historial de Movimientos"
        '
        'MenuItem293
        '
        Me.MenuItem293.Index = 7
        Me.MenuItem293.Text = "-"
        '
        'MenuItem294
        '
        Me.MenuItem294.Index = 8
        Me.MenuItem294.Text = "&6.- Balances a una Fecha"
        '
        'MenuItem550
        '
        Me.MenuItem550.Index = 9
        Me.MenuItem550.Text = "&7.- Balances por Facturas"
        '
        'MenuItem409
        '
        Me.MenuItem409.Index = 10
        Me.MenuItem409.Text = "-"
        '
        'MenuItem410
        '
        Me.MenuItem410.Index = 11
        Me.MenuItem410.Text = "&8.- Cuadrar Lotes"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 3
        Me.MenuItem14.Text = "&Ayuda"
        '
        'MenuItem15
        '
        Me.MenuItem15.Index = 4
        Me.MenuItem15.Text = "&Salida"
        '
        'inv
        '
        Me.inv.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem22, Me.MenuItem23, Me.MenuItem24, Me.MenuItem26, Me.MenuItem27})
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 0
        Me.MenuItem22.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem28, Me.MenuItem29, Me.MenuItem30, Me.MenuItem34, Me.MenuItem44, Me.MenuItem45, Me.MenuItem46, Me.MenuItem362, Me.MenuItem363, Me.MenuItem557})
        Me.MenuItem22.Text = "&Registros"
        '
        'MenuItem28
        '
        Me.MenuItem28.Index = 0
        Me.MenuItem28.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem249, Me.MenuItem250, Me.MenuItem251, Me.MenuItem252, Me.MenuItem253, Me.MenuItem254, Me.MenuItem255, Me.MenuItem256, Me.MenuItem257, Me.MenuItem258, Me.MenuItem270, Me.MenuItem271})
        Me.MenuItem28.Text = "&1.- Datos Generales"
        '
        'MenuItem249
        '
        Me.MenuItem249.Index = 0
        Me.MenuItem249.Text = "&0.- Marcas"
        '
        'MenuItem250
        '
        Me.MenuItem250.Index = 1
        Me.MenuItem250.Text = "&1.- Modelos"
        '
        'MenuItem251
        '
        Me.MenuItem251.Index = 2
        Me.MenuItem251.Text = "-"
        '
        'MenuItem252
        '
        Me.MenuItem252.Index = 3
        Me.MenuItem252.Text = "&2.- Unidades"
        '
        'MenuItem253
        '
        Me.MenuItem253.Index = 4
        Me.MenuItem253.Text = "&3.- Tipo Precio"
        '
        'MenuItem254
        '
        Me.MenuItem254.Index = 5
        Me.MenuItem254.Text = "-"
        '
        'MenuItem255
        '
        Me.MenuItem255.Index = 6
        Me.MenuItem255.Text = "&4.- Itbis"
        '
        'MenuItem256
        '
        Me.MenuItem256.Index = 7
        Me.MenuItem256.Text = "&5.- Origen"
        '
        'MenuItem257
        '
        Me.MenuItem257.Index = 8
        Me.MenuItem257.Text = "&6.- Grupos"
        '
        'MenuItem258
        '
        Me.MenuItem258.Index = 9
        Me.MenuItem258.Text = "&7.- Periodos"
        '
        'MenuItem270
        '
        Me.MenuItem270.Index = 10
        Me.MenuItem270.Text = "&8.- Clases"
        '
        'MenuItem271
        '
        Me.MenuItem271.Index = 11
        Me.MenuItem271.Text = "&9.- Actividad"
        '
        'MenuItem29
        '
        Me.MenuItem29.Index = 1
        Me.MenuItem29.Text = "-"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 2
        Me.MenuItem30.Text = "&2.- Registro de Art�culos"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 3
        Me.MenuItem34.Text = "-"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 4
        Me.MenuItem44.Text = "&3.- Departamentos"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 5
        Me.MenuItem45.Text = "4.- Almacenes"
        '
        'MenuItem46
        '
        Me.MenuItem46.Index = 6
        Me.MenuItem46.Text = "5.- Tipo Movimientos"
        '
        'MenuItem362
        '
        Me.MenuItem362.Index = 7
        Me.MenuItem362.Text = "-"
        '
        'MenuItem363
        '
        Me.MenuItem363.Index = 8
        Me.MenuItem363.Text = "&6.- Margenes Beneficios"
        '
        'MenuItem557
        '
        Me.MenuItem557.Index = 9
        Me.MenuItem557.Text = "&7.- Comisiones Estandar"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem88, Me.MenuItem89, Me.MenuItem295, Me.MenuItem90, Me.MenuItem406, Me.MenuItem407, Me.MenuItem527, Me.MenuItem558, Me.MenuItem559, Me.MenuItem566})
        Me.MenuItem23.Text = "&Procesos"
        '
        'MenuItem88
        '
        Me.MenuItem88.Index = 0
        Me.MenuItem88.Text = "&1.- Orden de Compra"
        '
        'MenuItem89
        '
        Me.MenuItem89.Index = 1
        Me.MenuItem89.Text = "&2.- Procesar Orden Compra"
        '
        'MenuItem295
        '
        Me.MenuItem295.Index = 2
        Me.MenuItem295.Text = "-"
        '
        'MenuItem90
        '
        Me.MenuItem90.Index = 3
        Me.MenuItem90.Text = "&3.- Movimientos Inventario"
        '
        'MenuItem406
        '
        Me.MenuItem406.Index = 4
        Me.MenuItem406.Text = "-"
        '
        'MenuItem407
        '
        Me.MenuItem407.Index = 5
        Me.MenuItem407.Text = "&4.- Inventario F�sico"
        '
        'MenuItem527
        '
        Me.MenuItem527.Index = 6
        Me.MenuItem527.Text = "&5.- Cuadre Vendedores"
        '
        'MenuItem558
        '
        Me.MenuItem558.Index = 7
        Me.MenuItem558.Text = "-"
        '
        'MenuItem559
        '
        Me.MenuItem559.Index = 8
        Me.MenuItem559.Text = "&6.- Definici�n de Ofertas"
        '
        'MenuItem566
        '
        Me.MenuItem566.Index = 9
        Me.MenuItem566.Text = "&7.- Arqueo Vendedores"
        '
        'MenuItem24
        '
        Me.MenuItem24.Index = 2
        Me.MenuItem24.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem47, Me.MenuItem272, Me.MenuItem91, Me.MenuItem273, Me.MenuItem274, Me.MenuItem275, Me.MenuItem276, Me.MenuItem324, Me.MenuItem325, Me.MenuItem326, Me.MenuItem333, Me.MenuItem334})
        Me.MenuItem24.Text = "&Reportes/Consultas"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 0
        Me.MenuItem47.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem48, Me.MenuItem259, Me.MenuItem260, Me.MenuItem261, Me.MenuItem262, Me.MenuItem263, Me.MenuItem264, Me.MenuItem265, Me.MenuItem266, Me.MenuItem267, Me.MenuItem268, Me.MenuItem269})
        Me.MenuItem47.Text = "&1.- Generales"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 0
        Me.MenuItem48.Text = "&0.- Marcas"
        '
        'MenuItem259
        '
        Me.MenuItem259.Index = 1
        Me.MenuItem259.Text = "1.- Modelos"
        '
        'MenuItem260
        '
        Me.MenuItem260.Index = 2
        Me.MenuItem260.Text = "-"
        '
        'MenuItem261
        '
        Me.MenuItem261.Index = 3
        Me.MenuItem261.Text = "&2.- Unidades"
        '
        'MenuItem262
        '
        Me.MenuItem262.Index = 4
        Me.MenuItem262.Text = "&3.- Tipo Precios"
        '
        'MenuItem263
        '
        Me.MenuItem263.Index = 5
        Me.MenuItem263.Text = "-"
        '
        'MenuItem264
        '
        Me.MenuItem264.Index = 6
        Me.MenuItem264.Text = "&4.- Itbis"
        '
        'MenuItem265
        '
        Me.MenuItem265.Index = 7
        Me.MenuItem265.Text = "&5.- Origenes"
        '
        'MenuItem266
        '
        Me.MenuItem266.Index = 8
        Me.MenuItem266.Text = "&6.- Grupos"
        '
        'MenuItem267
        '
        Me.MenuItem267.Index = 9
        Me.MenuItem267.Text = "&7.- Periodos"
        '
        'MenuItem268
        '
        Me.MenuItem268.Index = 10
        Me.MenuItem268.Text = "&8.- Clases"
        '
        'MenuItem269
        '
        Me.MenuItem269.Index = 11
        Me.MenuItem269.Text = "&9.- Actividad"
        '
        'MenuItem272
        '
        Me.MenuItem272.Index = 1
        Me.MenuItem272.Text = "-"
        '
        'MenuItem91
        '
        Me.MenuItem91.Index = 2
        Me.MenuItem91.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem327, Me.MenuItem328, Me.MenuItem329, Me.MenuItem330, Me.MenuItem331, Me.MenuItem332, Me.MenuItem414, Me.MenuItem415, Me.MenuItem416, Me.MenuItem477})
        Me.MenuItem91.Text = "&2.- Art�culos"
        '
        'MenuItem327
        '
        Me.MenuItem327.Index = 0
        Me.MenuItem327.Text = "&1.- Reporte Art�culos"
        '
        'MenuItem328
        '
        Me.MenuItem328.Index = 1
        Me.MenuItem328.Text = "&2.- Reporte Existencia x Alamc�n"
        '
        'MenuItem329
        '
        Me.MenuItem329.Index = 2
        Me.MenuItem329.Text = "&3.- Art�culos en Reorden"
        '
        'MenuItem330
        '
        Me.MenuItem330.Index = 3
        Me.MenuItem330.Text = "&4.- Art�culos Sobre el M�ximo"
        '
        'MenuItem331
        '
        Me.MenuItem331.Index = 4
        Me.MenuItem331.Text = "&5.- Reporte de Precio x Unidad"
        '
        'MenuItem332
        '
        Me.MenuItem332.Index = 5
        Me.MenuItem332.Text = "&6.- Tarjeta de Invenatario"
        '
        'MenuItem414
        '
        Me.MenuItem414.Index = 6
        Me.MenuItem414.Text = "&7.- Art�culos de Combos"
        '
        'MenuItem415
        '
        Me.MenuItem415.Index = 7
        Me.MenuItem415.Text = "-"
        '
        'MenuItem416
        '
        Me.MenuItem416.Index = 8
        Me.MenuItem416.Text = "&8.- Detalle de Transacciones"
        '
        'MenuItem477
        '
        Me.MenuItem477.Index = 9
        Me.MenuItem477.Text = "&9.- Existencia a una Fecha"
        '
        'MenuItem273
        '
        Me.MenuItem273.Index = 3
        Me.MenuItem273.Text = "-"
        '
        'MenuItem274
        '
        Me.MenuItem274.Index = 4
        Me.MenuItem274.Text = "&3.- Departamentos"
        '
        'MenuItem275
        '
        Me.MenuItem275.Index = 5
        Me.MenuItem275.Text = "&4.- Almacenes"
        '
        'MenuItem276
        '
        Me.MenuItem276.Index = 6
        Me.MenuItem276.Text = "&5.- Tipo Movimientos"
        '
        'MenuItem324
        '
        Me.MenuItem324.Index = 7
        Me.MenuItem324.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem478, Me.MenuItem479, Me.MenuItem530, Me.MenuItem531, Me.MenuItem535, Me.MenuItem536, Me.MenuItem552, Me.MenuItem553})
        Me.MenuItem324.Text = "&6.- Reporte de Movimientos"
        '
        'MenuItem478
        '
        Me.MenuItem478.Index = 0
        Me.MenuItem478.Text = "&1.- Resumido"
        '
        'MenuItem479
        '
        Me.MenuItem479.Index = 1
        Me.MenuItem479.Text = "&2.- Detallado"
        '
        'MenuItem530
        '
        Me.MenuItem530.Index = 2
        Me.MenuItem530.Text = "-"
        '
        'MenuItem531
        '
        Me.MenuItem531.Index = 3
        Me.MenuItem531.Text = "&3.- An�lisis de Ventas en Unidad"
        '
        'MenuItem535
        '
        Me.MenuItem535.Index = 4
        Me.MenuItem535.Text = "-"
        '
        'MenuItem536
        '
        Me.MenuItem536.Index = 5
        Me.MenuItem536.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem537, Me.MenuItem538, Me.MenuItem539, Me.MenuItem574, Me.MenuItem575})
        Me.MenuItem536.Text = "&4.- An�lisis Detalldo"
        '
        'MenuItem537
        '
        Me.MenuItem537.Index = 0
        Me.MenuItem537.Text = "&1.- An�lisis de Venta Unidad Mayor"
        '
        'MenuItem538
        '
        Me.MenuItem538.Index = 1
        Me.MenuItem538.Text = "-"
        '
        'MenuItem539
        '
        Me.MenuItem539.Index = 2
        Me.MenuItem539.Text = "&2.- An�lisis de Ventas por D�a"
        '
        'MenuItem574
        '
        Me.MenuItem574.Index = 3
        Me.MenuItem574.Text = "-"
        '
        'MenuItem575
        '
        Me.MenuItem575.Index = 4
        Me.MenuItem575.Text = "&3.- An�lisis de Venta Unidad Mayor(Todos)"
        '
        'MenuItem552
        '
        Me.MenuItem552.Index = 6
        Me.MenuItem552.Text = "-"
        '
        'MenuItem553
        '
        Me.MenuItem553.Index = 7
        Me.MenuItem553.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem554, Me.MenuItem556, Me.MenuItem555})
        Me.MenuItem553.Text = "&5.- Comisiones Vendedores"
        '
        'MenuItem554
        '
        Me.MenuItem554.Index = 0
        Me.MenuItem554.Text = "&1.- Comisiones Detalladas"
        '
        'MenuItem556
        '
        Me.MenuItem556.Index = 1
        Me.MenuItem556.Text = "-"
        '
        'MenuItem555
        '
        Me.MenuItem555.Index = 2
        Me.MenuItem555.Text = "&2.- Comisiones Totalizadas"
        '
        'MenuItem325
        '
        Me.MenuItem325.Index = 8
        Me.MenuItem325.Text = "&7.-An�lisis de Movimientos Detallado"
        '
        'MenuItem326
        '
        Me.MenuItem326.Index = 9
        Me.MenuItem326.Text = "&8.-An�lisis de Movimientos Resumido"
        '
        'MenuItem333
        '
        Me.MenuItem333.Index = 10
        Me.MenuItem333.Text = "-"
        '
        'MenuItem334
        '
        Me.MenuItem334.Index = 11
        Me.MenuItem334.Text = "&9.- Reporte de Itbis"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 3
        Me.MenuItem26.Text = "&Ayuda"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 4
        Me.MenuItem27.Text = "&Salir"
        '
        's1
        '
        Me.s1.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.s1.Location = New System.Drawing.Point(0, 321)
        Me.s1.Name = "s1"
        Me.s1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.p1, Me.p2})
        Me.s1.Size = New System.Drawing.Size(1028, 24)
        Me.s1.TabIndex = 6
        '
        'p1
        '
        Me.p1.Text = "StatusBarPanel1"
        '
        'p2
        '
        Me.p2.Text = "StatusBarPanel2"
        '
        'fac
        '
        Me.fac.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem127, Me.MenuItem128, Me.MenuItem129, Me.MenuItem130, Me.MenuItem131})
        '
        'MenuItem127
        '
        Me.MenuItem127.Index = 0
        Me.MenuItem127.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem182, Me.MenuItem184, Me.MenuItem180, Me.MenuItem193, Me.MenuItem185, Me.MenuItem183, Me.MenuItem181, Me.MenuItem408, Me.MenuItem393, Me.MenuItem483, Me.MenuItem484, Me.MenuItem512})
        Me.MenuItem127.Text = "&Registrar"
        '
        'MenuItem182
        '
        Me.MenuItem182.Index = 0
        Me.MenuItem182.Text = "&1.- Zonas de Operaci�n"
        '
        'MenuItem184
        '
        Me.MenuItem184.Index = 1
        Me.MenuItem184.Text = "-"
        '
        'MenuItem180
        '
        Me.MenuItem180.Index = 2
        Me.MenuItem180.Text = "&2.- Tarjetas con Problemas"
        '
        'MenuItem193
        '
        Me.MenuItem193.Index = 3
        Me.MenuItem193.Text = "&3.- Cajas de Ventas"
        '
        'MenuItem185
        '
        Me.MenuItem185.Index = 4
        Me.MenuItem185.Text = "-"
        '
        'MenuItem183
        '
        Me.MenuItem183.Index = 5
        Me.MenuItem183.Text = "&4.- Vendedores"
        '
        'MenuItem181
        '
        Me.MenuItem181.Index = 6
        Me.MenuItem181.Text = "&5.- Datos de Clientes"
        '
        'MenuItem408
        '
        Me.MenuItem408.Index = 7
        Me.MenuItem408.Text = "-"
        '
        'MenuItem393
        '
        Me.MenuItem393.Index = 8
        Me.MenuItem393.Text = "&6.- Lotes para facturas"
        '
        'MenuItem483
        '
        Me.MenuItem483.Index = 9
        Me.MenuItem483.Text = "-"
        '
        'MenuItem484
        '
        Me.MenuItem484.Index = 10
        Me.MenuItem484.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem486, Me.MenuItem487, Me.MenuItem485, Me.MenuItem488, Me.MenuItem489, Me.MenuItem569, Me.MenuItem572, Me.MenuItem573})
        Me.MenuItem484.Text = "&7.- Facturacion Movil"
        '
        'MenuItem486
        '
        Me.MenuItem486.Index = 0
        Me.MenuItem486.Text = "&1.- Tipo de Rutas"
        '
        'MenuItem487
        '
        Me.MenuItem487.Index = 1
        Me.MenuItem487.Text = "&2.- Ruta"
        '
        'MenuItem485
        '
        Me.MenuItem485.Index = 2
        Me.MenuItem485.Text = "&3.- Conceptos"
        '
        'MenuItem488
        '
        Me.MenuItem488.Index = 3
        Me.MenuItem488.Text = "-"
        '
        'MenuItem489
        '
        Me.MenuItem489.Index = 4
        Me.MenuItem489.Text = "&4.- Clientes M�viles"
        '
        'MenuItem569
        '
        Me.MenuItem569.Index = 5
        Me.MenuItem569.Text = "&5.- Ordenar Ruta"
        '
        'MenuItem572
        '
        Me.MenuItem572.Index = 6
        Me.MenuItem572.Text = "-"
        '
        'MenuItem573
        '
        Me.MenuItem573.Index = 7
        Me.MenuItem573.Text = "&6.- Generar Seriales"
        '
        'MenuItem512
        '
        Me.MenuItem512.Index = 11
        Me.MenuItem512.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem513, Me.MenuItem514, Me.MenuItem515, Me.MenuItem516})
        Me.MenuItem512.Text = "&8.- Ocasiones Especiales"
        '
        'MenuItem513
        '
        Me.MenuItem513.Index = 0
        Me.MenuItem513.Text = "&1.- Tipos de Ocasiones"
        '
        'MenuItem514
        '
        Me.MenuItem514.Index = 1
        Me.MenuItem514.Text = "&2.- Tipos de Relaciones"
        '
        'MenuItem515
        '
        Me.MenuItem515.Index = 2
        Me.MenuItem515.Text = "-"
        '
        'MenuItem516
        '
        Me.MenuItem516.Index = 3
        Me.MenuItem516.Text = "&3.- Contactos Ocasiones"
        '
        'MenuItem128
        '
        Me.MenuItem128.Index = 1
        Me.MenuItem128.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem186, Me.MenuItem188, Me.MenuItem195, Me.MenuItem187, Me.MenuItem189, Me.MenuItem190, Me.MenuItem191, Me.MenuItem25, Me.MenuItem298, Me.MenuItem560, Me.MenuItem567, Me.MenuItem568})
        Me.MenuItem128.Text = "&Procesos"
        '
        'MenuItem186
        '
        Me.MenuItem186.Index = 0
        Me.MenuItem186.Text = "&1.- Facturaci�n y Ventas"
        '
        'MenuItem188
        '
        Me.MenuItem188.Index = 1
        Me.MenuItem188.Text = "-"
        '
        'MenuItem195
        '
        Me.MenuItem195.Index = 2
        Me.MenuItem195.Text = "&2.- Egresos de Cajas"
        '
        'MenuItem187
        '
        Me.MenuItem187.Index = 3
        Me.MenuItem187.Text = "&3.- Pagos a Facturas"
        '
        'MenuItem189
        '
        Me.MenuItem189.Index = 4
        Me.MenuItem189.Text = "&4.- Notas D�bito/Cr�dito"
        '
        'MenuItem190
        '
        Me.MenuItem190.Index = 5
        Me.MenuItem190.Text = "-"
        '
        'MenuItem191
        '
        Me.MenuItem191.Index = 6
        Me.MenuItem191.Text = "&5.- Cuadre de Caja"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 7
        Me.MenuItem25.Text = "-"
        '
        'MenuItem298
        '
        Me.MenuItem298.Index = 8
        Me.MenuItem298.Text = "&6.- Procesar Cotizaci�n"
        '
        'MenuItem560
        '
        Me.MenuItem560.Index = 9
        Me.MenuItem560.Text = "&7.- Integraci�n Ventas Movil"
        '
        'MenuItem567
        '
        Me.MenuItem567.Index = 10
        Me.MenuItem567.Text = "-"
        '
        'MenuItem568
        '
        Me.MenuItem568.Index = 11
        Me.MenuItem568.Text = "&8.- Archivo de Ventas"
        '
        'MenuItem129
        '
        Me.MenuItem129.Index = 2
        Me.MenuItem129.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem192, Me.MenuItem194, Me.MenuItem196, Me.MenuItem197, Me.MenuItem244, Me.MenuItem198, Me.MenuItem210, Me.MenuItem214, Me.MenuItem202, Me.MenuItem206, Me.MenuItem417, Me.MenuItem418, Me.MenuItem490, Me.MenuItem491, Me.MenuItem517})
        Me.MenuItem129.Text = "Re&portes/Consultas"
        '
        'MenuItem192
        '
        Me.MenuItem192.Index = 0
        Me.MenuItem192.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem544, Me.MenuItem545, Me.MenuItem546})
        Me.MenuItem192.Text = "&1.- Relaci�n de Movimientos"
        '
        'MenuItem544
        '
        Me.MenuItem544.Index = 0
        Me.MenuItem544.Text = "&1.- Relaci�n de Ventas"
        '
        'MenuItem545
        '
        Me.MenuItem545.Index = 1
        Me.MenuItem545.Text = "-"
        '
        'MenuItem546
        '
        Me.MenuItem546.Index = 2
        Me.MenuItem546.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem547, Me.MenuItem548, Me.MenuItem549})
        Me.MenuItem546.Text = "&2.- Comisiones Vendedores"
        '
        'MenuItem547
        '
        Me.MenuItem547.Index = 0
        Me.MenuItem547.Text = "1.- Comisiones Detalladas"
        '
        'MenuItem548
        '
        Me.MenuItem548.Index = 1
        Me.MenuItem548.Text = "-"
        '
        'MenuItem549
        '
        Me.MenuItem549.Index = 2
        Me.MenuItem549.Text = "&2.- Comisiones Totalizadas"
        '
        'MenuItem194
        '
        Me.MenuItem194.Index = 1
        Me.MenuItem194.Text = "-"
        '
        'MenuItem196
        '
        Me.MenuItem196.Index = 2
        Me.MenuItem196.Text = "&2.- Balance Actuales"
        '
        'MenuItem197
        '
        Me.MenuItem197.Index = 3
        Me.MenuItem197.Text = "&3.- Facturas Pendientes"
        '
        'MenuItem244
        '
        Me.MenuItem244.Index = 4
        Me.MenuItem244.Text = "-"
        '
        'MenuItem198
        '
        Me.MenuItem198.Index = 5
        Me.MenuItem198.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem199, Me.MenuItem200, Me.MenuItem201})
        Me.MenuItem198.Text = "&4.- Pagos de Clientes"
        '
        'MenuItem199
        '
        Me.MenuItem199.Index = 0
        Me.MenuItem199.Text = "&1.- Pagos Detallados"
        '
        'MenuItem200
        '
        Me.MenuItem200.Index = 1
        Me.MenuItem200.Text = "-"
        '
        'MenuItem201
        '
        Me.MenuItem201.Index = 2
        Me.MenuItem201.Text = "&2.- Pagos Totalizados"
        '
        'MenuItem210
        '
        Me.MenuItem210.Index = 6
        Me.MenuItem210.Text = "&5.- Egresos de Caja"
        '
        'MenuItem214
        '
        Me.MenuItem214.Index = 7
        Me.MenuItem214.Text = "-"
        '
        'MenuItem202
        '
        Me.MenuItem202.Index = 8
        Me.MenuItem202.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem203, Me.MenuItem204, Me.MenuItem205})
        Me.MenuItem202.Text = "&6.- Notas a Facturas"
        '
        'MenuItem203
        '
        Me.MenuItem203.Index = 0
        Me.MenuItem203.Text = "&1.- Notas Detallas"
        '
        'MenuItem204
        '
        Me.MenuItem204.Index = 1
        Me.MenuItem204.Text = "-"
        '
        'MenuItem205
        '
        Me.MenuItem205.Index = 2
        Me.MenuItem205.Text = "&2.- Notas Totalizadas"
        '
        'MenuItem206
        '
        Me.MenuItem206.Index = 9
        Me.MenuItem206.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem207, Me.MenuItem208, Me.MenuItem209})
        Me.MenuItem206.Text = "&7.- Anticipos a Facturas"
        '
        'MenuItem207
        '
        Me.MenuItem207.Index = 0
        Me.MenuItem207.Text = "&1.- Anticipos Detallados"
        '
        'MenuItem208
        '
        Me.MenuItem208.Index = 1
        Me.MenuItem208.Text = "-"
        '
        'MenuItem209
        '
        Me.MenuItem209.Index = 2
        Me.MenuItem209.Text = "&2.- Anticipos Aplicados"
        '
        'MenuItem417
        '
        Me.MenuItem417.Index = 10
        Me.MenuItem417.Text = "-"
        '
        'MenuItem418
        '
        Me.MenuItem418.Index = 11
        Me.MenuItem418.Text = "&8.- Detalle de Transacciones"
        '
        'MenuItem490
        '
        Me.MenuItem490.Index = 12
        Me.MenuItem490.Text = "-"
        '
        'MenuItem491
        '
        Me.MenuItem491.Index = 13
        Me.MenuItem491.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem492, Me.MenuItem510, Me.MenuItem511, Me.MenuItem561, Me.MenuItem562})
        Me.MenuItem491.Text = "&9.- Facturaci�n M�vil"
        '
        'MenuItem492
        '
        Me.MenuItem492.Index = 0
        Me.MenuItem492.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem493, Me.MenuItem494, Me.MenuItem495, Me.MenuItem496, Me.MenuItem497, Me.MenuItem509, Me.MenuItem508})
        Me.MenuItem492.Text = "&1.- Generales"
        '
        'MenuItem493
        '
        Me.MenuItem493.Index = 0
        Me.MenuItem493.Text = "&1.- Utensilios / Adornos"
        '
        'MenuItem494
        '
        Me.MenuItem494.Index = 1
        Me.MenuItem494.Text = "&2.- Paneles / Divisiones"
        '
        'MenuItem495
        '
        Me.MenuItem495.Index = 2
        Me.MenuItem495.Text = "&3.- Usos Secciones"
        '
        'MenuItem496
        '
        Me.MenuItem496.Index = 3
        Me.MenuItem496.Text = "-"
        '
        'MenuItem497
        '
        Me.MenuItem497.Index = 4
        Me.MenuItem497.Text = "&4.- Secciones"
        '
        'MenuItem509
        '
        Me.MenuItem509.Index = 5
        Me.MenuItem509.Text = "-"
        '
        'MenuItem508
        '
        Me.MenuItem508.Index = 6
        Me.MenuItem508.Text = "&5.- Precios por Secci�n"
        '
        'MenuItem510
        '
        Me.MenuItem510.Index = 1
        Me.MenuItem510.Text = "-"
        '
        'MenuItem511
        '
        Me.MenuItem511.Index = 2
        Me.MenuItem511.Text = "&2.- Clientes X Rutas"
        '
        'MenuItem561
        '
        Me.MenuItem561.Index = 3
        Me.MenuItem561.Text = "-"
        '
        'MenuItem562
        '
        Me.MenuItem562.Index = 4
        Me.MenuItem562.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem563, Me.MenuItem565, Me.MenuItem564})
        Me.MenuItem562.Text = "&3.- Visitas Clientes"
        '
        'MenuItem563
        '
        Me.MenuItem563.Index = 0
        Me.MenuItem563.Text = "&1.- Visitas Detalladas"
        '
        'MenuItem565
        '
        Me.MenuItem565.Index = 1
        Me.MenuItem565.Text = "-"
        '
        'MenuItem564
        '
        Me.MenuItem564.Index = 2
        Me.MenuItem564.Text = "&2.- Visitas Totalizadas"
        '
        'MenuItem517
        '
        Me.MenuItem517.Index = 14
        Me.MenuItem517.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem518, Me.MenuItem519, Me.MenuItem520, Me.MenuItem521, Me.MenuItem522, Me.MenuItem523, Me.MenuItem524})
        Me.MenuItem517.Text = "&0.- Ocasiones Espaciales"
        '
        'MenuItem518
        '
        Me.MenuItem518.Index = 0
        Me.MenuItem518.Text = "&1.- Ocasiones Especiales Fechas"
        '
        'MenuItem519
        '
        Me.MenuItem519.Index = 1
        Me.MenuItem519.Text = "-"
        '
        'MenuItem520
        '
        Me.MenuItem520.Index = 2
        Me.MenuItem520.Text = "&2.- Contactos con sus fechas"
        '
        'MenuItem521
        '
        Me.MenuItem521.Index = 3
        Me.MenuItem521.Text = "&3.- Conactos con sus relaciones"
        '
        'MenuItem522
        '
        Me.MenuItem522.Index = 4
        Me.MenuItem522.Text = "-"
        '
        'MenuItem523
        '
        Me.MenuItem523.Index = 5
        Me.MenuItem523.Text = "&4.- Tipos de Ocasiones"
        '
        'MenuItem524
        '
        Me.MenuItem524.Index = 6
        Me.MenuItem524.Text = "&5.- Tipos de Relaciones"
        '
        'MenuItem130
        '
        Me.MenuItem130.Index = 3
        Me.MenuItem130.Text = "&Ayuda"
        '
        'MenuItem131
        '
        Me.MenuItem131.Index = 4
        Me.MenuItem131.Text = "&Salida"
        '
        'nom
        '
        Me.nom.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem132, Me.MenuItem133, Me.MenuItem140, Me.MenuItem143, Me.MenuItem147})
        '
        'MenuItem132
        '
        Me.MenuItem132.Index = 0
        Me.MenuItem132.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem340, Me.MenuItem353, Me.MenuItem359, Me.MenuItem361, Me.MenuItem354, Me.MenuItem364, Me.MenuItem403})
        Me.MenuItem132.Text = "&Registrar"
        '
        'MenuItem340
        '
        Me.MenuItem340.Index = 0
        Me.MenuItem340.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem344, Me.MenuItem345, Me.MenuItem346, Me.MenuItem347, Me.MenuItem356, Me.MenuItem357, Me.MenuItem358, Me.MenuItem355, Me.MenuItem360})
        Me.MenuItem340.Text = "&1- Datos Generales"
        '
        'MenuItem344
        '
        Me.MenuItem344.Index = 0
        Me.MenuItem344.Text = "&1.- Ocupaciones"
        '
        'MenuItem345
        '
        Me.MenuItem345.Index = 1
        Me.MenuItem345.Text = "&2.- Niveles Acad�micos"
        '
        'MenuItem346
        '
        Me.MenuItem346.Index = 2
        Me.MenuItem346.Text = "&3.- Estados"
        '
        'MenuItem347
        '
        Me.MenuItem347.Index = 3
        Me.MenuItem347.Text = "&4.- Tipo de Sangre"
        '
        'MenuItem356
        '
        Me.MenuItem356.Index = 4
        Me.MenuItem356.Text = "&5.- T�tulo de Cortes�a"
        '
        'MenuItem357
        '
        Me.MenuItem357.Index = 5
        Me.MenuItem357.Text = "&6.- Empresas de AFP"
        '
        'MenuItem358
        '
        Me.MenuItem358.Index = 6
        Me.MenuItem358.Text = "&7.- Empresas de ARS"
        '
        'MenuItem355
        '
        Me.MenuItem355.Index = 7
        Me.MenuItem355.Text = "&8.- Tipo N�mina"
        '
        'MenuItem360
        '
        Me.MenuItem360.Index = 8
        Me.MenuItem360.Text = "&9.- Grupos"
        '
        'MenuItem353
        '
        Me.MenuItem353.Index = 1
        Me.MenuItem353.Text = "&2.- Departamentos"
        '
        'MenuItem359
        '
        Me.MenuItem359.Index = 2
        Me.MenuItem359.Text = "&3.- Empleados"
        '
        'MenuItem361
        '
        Me.MenuItem361.Index = 3
        Me.MenuItem361.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem396, Me.MenuItem397, Me.MenuItem398, Me.MenuItem399, Me.MenuItem400, Me.MenuItem570})
        Me.MenuItem361.Text = "&4.- Reloj"
        '
        'MenuItem396
        '
        Me.MenuItem396.Index = 0
        Me.MenuItem396.Text = "&0.- Registro de Reloj"
        '
        'MenuItem397
        '
        Me.MenuItem397.Index = 1
        Me.MenuItem397.Text = "&1.- D�as Feriados"
        '
        'MenuItem398
        '
        Me.MenuItem398.Index = 2
        Me.MenuItem398.Text = "&2.- Periodo Trabajo"
        '
        'MenuItem399
        '
        Me.MenuItem399.Index = 3
        Me.MenuItem399.Text = "&3.- Tipo de Horas"
        '
        'MenuItem400
        '
        Me.MenuItem400.Index = 4
        Me.MenuItem400.Text = "&4.- Turnos"
        '
        'MenuItem570
        '
        Me.MenuItem570.Index = 5
        Me.MenuItem570.Text = "&5.- Registro de Horas"
        '
        'MenuItem354
        '
        Me.MenuItem354.Index = 4
        Me.MenuItem354.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem365, Me.MenuItem366})
        Me.MenuItem354.Text = "&6.- Descuentos"
        '
        'MenuItem365
        '
        Me.MenuItem365.Index = 0
        Me.MenuItem365.Text = "&0.- Tipo Descuentos"
        '
        'MenuItem366
        '
        Me.MenuItem366.Index = 1
        Me.MenuItem366.Text = "&1.- Registro de Descuentos"
        '
        'MenuItem364
        '
        Me.MenuItem364.Index = 5
        Me.MenuItem364.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem401, Me.MenuItem402})
        Me.MenuItem364.Text = "&7.- Ingresos"
        '
        'MenuItem401
        '
        Me.MenuItem401.Index = 0
        Me.MenuItem401.Text = "&0.- Tipo de Ingresos"
        '
        'MenuItem402
        '
        Me.MenuItem402.Index = 1
        Me.MenuItem402.Text = "&1.- Registro de Ingresos"
        '
        'MenuItem403
        '
        Me.MenuItem403.Index = 6
        Me.MenuItem403.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem404, Me.MenuItem405})
        Me.MenuItem403.Text = "&8.- Pr�stamos"
        '
        'MenuItem404
        '
        Me.MenuItem404.Index = 0
        Me.MenuItem404.Text = "&0.- Concepto de Pr�stamos"
        '
        'MenuItem405
        '
        Me.MenuItem405.Index = 1
        Me.MenuItem405.Text = "&1.- Registro de Pr�stamos"
        '
        'MenuItem133
        '
        Me.MenuItem133.Index = 1
        Me.MenuItem133.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem370, Me.MenuItem371, Me.MenuItem372, Me.MenuItem394, Me.MenuItem480, Me.MenuItem367, Me.MenuItem411, Me.MenuItem571})
        Me.MenuItem133.Text = "&Procesos"
        '
        'MenuItem370
        '
        Me.MenuItem370.Index = 0
        Me.MenuItem370.Text = "1.- Importar Ponches"
        '
        'MenuItem371
        '
        Me.MenuItem371.Index = 1
        Me.MenuItem371.Text = "&2.- Procesar Ponches"
        '
        'MenuItem372
        '
        Me.MenuItem372.Index = 2
        Me.MenuItem372.Text = "&3.- Configraci�n de Horarios"
        '
        'MenuItem394
        '
        Me.MenuItem394.Index = 3
        Me.MenuItem394.Text = "&4.- Apertura de N�mina"
        '
        'MenuItem480
        '
        Me.MenuItem480.Index = 4
        Me.MenuItem480.Text = "&5.- Procesar N�mina"
        '
        'MenuItem367
        '
        Me.MenuItem367.Index = 5
        Me.MenuItem367.Text = "&6.- Cerrar N�mina"
        '
        'MenuItem411
        '
        Me.MenuItem411.Index = 6
        Me.MenuItem411.Text = "&7.- Cambio de Salario"
        '
        'MenuItem571
        '
        Me.MenuItem571.Index = 7
        Me.MenuItem571.Text = "&8.- Consulta Cambio de Salario"
        '
        'MenuItem140
        '
        Me.MenuItem140.Index = 2
        Me.MenuItem140.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem378, Me.MenuItem388, Me.MenuItem389, Me.MenuItem390, Me.MenuItem391, Me.MenuItem392, Me.MenuItem412, Me.MenuItem413, Me.MenuItem373})
        Me.MenuItem140.Text = "Re&portes/Consultas"
        '
        'MenuItem378
        '
        Me.MenuItem378.Index = 0
        Me.MenuItem378.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem379, Me.MenuItem380, Me.MenuItem381, Me.MenuItem382, Me.MenuItem383, Me.MenuItem384, Me.MenuItem385, Me.MenuItem386, Me.MenuItem387})
        Me.MenuItem378.Text = "&1.- Generales"
        '
        'MenuItem379
        '
        Me.MenuItem379.Index = 0
        Me.MenuItem379.Text = "&1.- Ocupaciones"
        '
        'MenuItem380
        '
        Me.MenuItem380.Index = 1
        Me.MenuItem380.Text = "&2.- Niveles Acad�micos"
        '
        'MenuItem381
        '
        Me.MenuItem381.Index = 2
        Me.MenuItem381.Text = "&3.- Estados"
        '
        'MenuItem382
        '
        Me.MenuItem382.Index = 3
        Me.MenuItem382.Text = "&4.- Tipos de Sangres"
        '
        'MenuItem383
        '
        Me.MenuItem383.Index = 4
        Me.MenuItem383.Text = "&5.- T�tulos de Cortes�as"
        '
        'MenuItem384
        '
        Me.MenuItem384.Index = 5
        Me.MenuItem384.Text = "&6.- Empresas de AFP"
        '
        'MenuItem385
        '
        Me.MenuItem385.Index = 6
        Me.MenuItem385.Text = "&7.- Empresas de ARS"
        '
        'MenuItem386
        '
        Me.MenuItem386.Index = 7
        Me.MenuItem386.Text = "&8.- Tipo de N�mina"
        '
        'MenuItem387
        '
        Me.MenuItem387.Index = 8
        Me.MenuItem387.Text = "&9.- Grupos"
        '
        'MenuItem388
        '
        Me.MenuItem388.Index = 1
        Me.MenuItem388.Text = "&2.- Departamentos"
        '
        'MenuItem389
        '
        Me.MenuItem389.Index = 2
        Me.MenuItem389.Text = "&3.- Turnos"
        '
        'MenuItem390
        '
        Me.MenuItem390.Index = 3
        Me.MenuItem390.Text = "4.- Empleados"
        '
        'MenuItem391
        '
        Me.MenuItem391.Index = 4
        Me.MenuItem391.Text = "&5.- Reloj"
        '
        'MenuItem392
        '
        Me.MenuItem392.Index = 5
        Me.MenuItem392.Text = "&6.- D�as Feriados"
        '
        'MenuItem412
        '
        Me.MenuItem412.Index = 6
        Me.MenuItem412.Text = "&7.- Pren�mina"
        '
        'MenuItem413
        '
        Me.MenuItem413.Index = 7
        Me.MenuItem413.Text = "&8.- N�mina"
        '
        'MenuItem373
        '
        Me.MenuItem373.Index = 8
        Me.MenuItem373.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem374, Me.MenuItem375, Me.MenuItem395})
        Me.MenuItem373.Text = "&9.- Pr�stamos"
        '
        'MenuItem374
        '
        Me.MenuItem374.Index = 0
        Me.MenuItem374.Text = "&0.- Reportes de Pr�stamos"
        '
        'MenuItem375
        '
        Me.MenuItem375.Index = 1
        Me.MenuItem375.Text = "&1.- Reportes de Pagos "
        '
        'MenuItem395
        '
        Me.MenuItem395.Index = 2
        Me.MenuItem395.Text = "&2.- Historico de Pr�stamos"
        '
        'MenuItem143
        '
        Me.MenuItem143.Index = 3
        Me.MenuItem143.Text = "&Ayuda"
        '
        'MenuItem147
        '
        Me.MenuItem147.Index = 4
        Me.MenuItem147.Text = "&Salida"
        '
        'ban
        '
        Me.ban.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem170, Me.MenuItem171, Me.MenuItem172, Me.MenuItem173, Me.MenuItem174})
        '
        'MenuItem170
        '
        Me.MenuItem170.Index = 0
        Me.MenuItem170.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem211, Me.MenuItem212, Me.MenuItem213, Me.MenuItem215})
        Me.MenuItem170.Text = "&Registrar"
        '
        'MenuItem211
        '
        Me.MenuItem211.Index = 0
        Me.MenuItem211.Text = "&1.- Tipos de Movimientos"
        '
        'MenuItem212
        '
        Me.MenuItem212.Index = 1
        Me.MenuItem212.Text = "-"
        '
        'MenuItem213
        '
        Me.MenuItem213.Index = 2
        Me.MenuItem213.Text = "&2.- Cuentas de Bancos"
        '
        'MenuItem215
        '
        Me.MenuItem215.Index = 3
        Me.MenuItem215.Text = "&3.- Secuencias Documentos"
        '
        'MenuItem171
        '
        Me.MenuItem171.Index = 1
        Me.MenuItem171.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem216, Me.MenuItem217, Me.MenuItem220, Me.MenuItem218, Me.MenuItem525, Me.MenuItem526})
        Me.MenuItem171.Text = "&Procesos"
        '
        'MenuItem216
        '
        Me.MenuItem216.Index = 0
        Me.MenuItem216.Text = "&1.- Movimientos Bancarios"
        '
        'MenuItem217
        '
        Me.MenuItem217.Index = 1
        Me.MenuItem217.Text = "&2.- Cotejo de Operaciones"
        '
        'MenuItem220
        '
        Me.MenuItem220.Index = 2
        Me.MenuItem220.Text = "-"
        '
        'MenuItem218
        '
        Me.MenuItem218.Index = 3
        Me.MenuItem218.Text = "&3.- Conciliaci�n Bancaria"
        '
        'MenuItem525
        '
        Me.MenuItem525.Index = 4
        Me.MenuItem525.Text = "-"
        '
        'MenuItem526
        '
        Me.MenuItem526.Index = 5
        Me.MenuItem526.Text = "&4.- Solicitud de Cheques"
        '
        'MenuItem172
        '
        Me.MenuItem172.Index = 2
        Me.MenuItem172.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem221, Me.MenuItem222, Me.MenuItem225, Me.MenuItem224, Me.MenuItem223, Me.MenuItem528, Me.MenuItem529})
        Me.MenuItem172.Text = "Re&portes/Consultas"
        '
        'MenuItem221
        '
        Me.MenuItem221.Index = 0
        Me.MenuItem221.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem219, Me.MenuItem226, Me.MenuItem227, Me.MenuItem542, Me.MenuItem543})
        Me.MenuItem221.Text = "&1.- Relaci�n de Operaciones"
        '
        'MenuItem219
        '
        Me.MenuItem219.Index = 0
        Me.MenuItem219.Text = "&1.- Detalle Operaci�n"
        '
        'MenuItem226
        '
        Me.MenuItem226.Index = 1
        Me.MenuItem226.Text = "-"
        '
        'MenuItem227
        '
        Me.MenuItem227.Index = 2
        Me.MenuItem227.Text = "&2.- Beneficiario Operaci�n"
        '
        'MenuItem542
        '
        Me.MenuItem542.Index = 3
        Me.MenuItem542.Text = "-"
        '
        'MenuItem543
        '
        Me.MenuItem543.Index = 4
        Me.MenuItem543.Text = "&3.- Relaci�n de Movimientos"
        '
        'MenuItem222
        '
        Me.MenuItem222.Index = 1
        Me.MenuItem222.Text = "&2.- Estado de Cuenta"
        '
        'MenuItem225
        '
        Me.MenuItem225.Index = 2
        Me.MenuItem225.Text = "-"
        '
        'MenuItem224
        '
        Me.MenuItem224.Index = 3
        Me.MenuItem224.Text = "&3.- Historial de Transitos"
        '
        'MenuItem223
        '
        Me.MenuItem223.Index = 4
        Me.MenuItem223.Text = "&4.- Cuentas de Banco"
        '
        'MenuItem528
        '
        Me.MenuItem528.Index = 5
        Me.MenuItem528.Text = "-"
        '
        'MenuItem529
        '
        Me.MenuItem529.Index = 6
        Me.MenuItem529.Text = "&5.- Desembolsos Semanales"
        '
        'MenuItem173
        '
        Me.MenuItem173.Index = 3
        Me.MenuItem173.Text = "&Ayuda"
        '
        'MenuItem174
        '
        Me.MenuItem174.Index = 4
        Me.MenuItem174.Text = "&Salida"
        '
        'cnt
        '
        Me.cnt.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem150, Me.MenuItem166, Me.MenuItem167, Me.MenuItem168, Me.MenuItem169})
        '
        'MenuItem150
        '
        Me.MenuItem150.Index = 0
        Me.MenuItem150.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem228, Me.MenuItem229, Me.MenuItem231, Me.MenuItem230})
        Me.MenuItem150.Text = "&Registrar"
        '
        'MenuItem228
        '
        Me.MenuItem228.Index = 0
        Me.MenuItem228.Text = "&1.- Tipos de Documentos"
        '
        'MenuItem229
        '
        Me.MenuItem229.Index = 1
        Me.MenuItem229.Text = "-"
        '
        'MenuItem231
        '
        Me.MenuItem231.Index = 2
        Me.MenuItem231.Text = "&2.- Clasificaci�n de Cuentas"
        '
        'MenuItem230
        '
        Me.MenuItem230.Index = 3
        Me.MenuItem230.Text = "&3.- Cuentas Contabilidad"
        '
        'MenuItem166
        '
        Me.MenuItem166.Index = 1
        Me.MenuItem166.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem232, Me.MenuItem233, Me.MenuItem234, Me.MenuItem235, Me.MenuItem296, Me.MenuItem297, Me.MenuItem368, Me.MenuItem369})
        Me.MenuItem166.Text = "&Procesos"
        '
        'MenuItem232
        '
        Me.MenuItem232.Index = 0
        Me.MenuItem232.Text = "&1.- Entradas de Diario"
        '
        'MenuItem233
        '
        Me.MenuItem233.Index = 1
        Me.MenuItem233.Text = "-"
        '
        'MenuItem234
        '
        Me.MenuItem234.Index = 2
        Me.MenuItem234.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem299, Me.MenuItem300, Me.MenuItem301})
        Me.MenuItem234.Text = "&2.- Procesar Mes"
        '
        'MenuItem299
        '
        Me.MenuItem299.Index = 0
        Me.MenuItem299.Text = "&1.- Cierre de Mes"
        '
        'MenuItem300
        '
        Me.MenuItem300.Index = 1
        Me.MenuItem300.Text = "-"
        '
        'MenuItem301
        '
        Me.MenuItem301.Index = 2
        Me.MenuItem301.Text = "&2.- Quitar Cierre de mes"
        '
        'MenuItem235
        '
        Me.MenuItem235.Index = 3
        Me.MenuItem235.Text = "&3.- Cierre Fiscal"
        '
        'MenuItem296
        '
        Me.MenuItem296.Index = 4
        Me.MenuItem296.Text = "-"
        '
        'MenuItem297
        '
        Me.MenuItem297.Index = 5
        Me.MenuItem297.Text = "&4.- Cuenta Vs Auxiliar"
        '
        'MenuItem368
        '
        Me.MenuItem368.Index = 6
        Me.MenuItem368.Text = "-"
        '
        'MenuItem369
        '
        Me.MenuItem369.Index = 7
        Me.MenuItem369.Text = "&5.- Dise�ar Estados Financieros"
        '
        'MenuItem167
        '
        Me.MenuItem167.Index = 2
        Me.MenuItem167.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem236, Me.MenuItem237, Me.MenuItem238, Me.MenuItem239, Me.MenuItem240, Me.MenuItem241, Me.MenuItem242, Me.MenuItem243, Me.MenuItem245, Me.MenuItem506, Me.MenuItem507, Me.MenuItem532, Me.MenuItem533})
        Me.MenuItem167.Text = "Re&portes/Consultas"
        '
        'MenuItem236
        '
        Me.MenuItem236.Index = 0
        Me.MenuItem236.Text = "&1.- Diario General"
        '
        'MenuItem237
        '
        Me.MenuItem237.Index = 1
        Me.MenuItem237.Text = "&2.- Mayor General"
        '
        'MenuItem238
        '
        Me.MenuItem238.Index = 2
        Me.MenuItem238.Text = "-"
        '
        'MenuItem239
        '
        Me.MenuItem239.Index = 3
        Me.MenuItem239.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem246, Me.MenuItem247, Me.MenuItem248})
        Me.MenuItem239.Text = "&3.- Balance de Compraci�n"
        '
        'MenuItem246
        '
        Me.MenuItem246.Index = 0
        Me.MenuItem246.Text = "&1.- Balance de Actual"
        '
        'MenuItem247
        '
        Me.MenuItem247.Index = 1
        Me.MenuItem247.Text = "-"
        '
        'MenuItem248
        '
        Me.MenuItem248.Index = 2
        Me.MenuItem248.Text = "&2.- Balance Comparado"
        '
        'MenuItem240
        '
        Me.MenuItem240.Index = 4
        Me.MenuItem240.Text = "-"
        '
        'MenuItem241
        '
        Me.MenuItem241.Index = 5
        Me.MenuItem241.Text = "&4.- Estado e Cuenta"
        '
        'MenuItem242
        '
        Me.MenuItem242.Index = 6
        Me.MenuItem242.Text = "&5.- Cat�logo de Cuentas"
        '
        'MenuItem243
        '
        Me.MenuItem243.Index = 7
        Me.MenuItem243.Text = "-"
        '
        'MenuItem245
        '
        Me.MenuItem245.Index = 8
        Me.MenuItem245.Text = "&6.- Estados Financieros"
        '
        'MenuItem506
        '
        Me.MenuItem506.Index = 9
        Me.MenuItem506.Text = "-"
        '
        'MenuItem507
        '
        Me.MenuItem507.Index = 10
        Me.MenuItem507.Text = "&7.- Resumen por Mes"
        '
        'MenuItem532
        '
        Me.MenuItem532.Index = 11
        Me.MenuItem532.Text = "-"
        '
        'MenuItem533
        '
        Me.MenuItem533.Index = 12
        Me.MenuItem533.Text = "&8.- Entrada Descuadrada"
        '
        'MenuItem168
        '
        Me.MenuItem168.Index = 3
        Me.MenuItem168.Text = "&Ayuda"
        '
        'MenuItem169
        '
        Me.MenuItem169.Index = 4
        Me.MenuItem169.Text = "&Salida"
        '
        'act
        '
        Me.act.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem175, Me.MenuItem176, Me.MenuItem177, Me.MenuItem178, Me.MenuItem179})
        '
        'MenuItem175
        '
        Me.MenuItem175.Index = 0
        Me.MenuItem175.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem302, Me.MenuItem303, Me.MenuItem310, Me.MenuItem304, Me.MenuItem305, Me.MenuItem306, Me.MenuItem307, Me.MenuItem308, Me.MenuItem309})
        Me.MenuItem175.Text = "&Registrar"
        '
        'MenuItem302
        '
        Me.MenuItem302.Index = 0
        Me.MenuItem302.Text = "&1.- Localizaciones"
        '
        'MenuItem303
        '
        Me.MenuItem303.Index = 1
        Me.MenuItem303.Text = "&2.- Marcas"
        '
        'MenuItem310
        '
        Me.MenuItem310.Index = 2
        Me.MenuItem310.Text = "-"
        '
        'MenuItem304
        '
        Me.MenuItem304.Index = 3
        Me.MenuItem304.Text = "&3.- Cuentas Contabilidad"
        '
        'MenuItem305
        '
        Me.MenuItem305.Index = 4
        Me.MenuItem305.Text = "&4.- Grupos de Activos"
        '
        'MenuItem306
        '
        Me.MenuItem306.Index = 5
        Me.MenuItem306.Text = "-"
        '
        'MenuItem307
        '
        Me.MenuItem307.Index = 6
        Me.MenuItem307.Text = "&4.- Activos Fijos"
        '
        'MenuItem308
        '
        Me.MenuItem308.Index = 7
        Me.MenuItem308.Text = "-"
        '
        'MenuItem309
        '
        Me.MenuItem309.Index = 8
        Me.MenuItem309.Text = "&5.- Suplidores"
        '
        'MenuItem176
        '
        Me.MenuItem176.Index = 1
        Me.MenuItem176.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem311, Me.MenuItem313, Me.MenuItem314, Me.MenuItem312})
        Me.MenuItem176.Text = "&Procesos"
        '
        'MenuItem311
        '
        Me.MenuItem311.Index = 0
        Me.MenuItem311.Text = "&1.- Movimientos Activos"
        '
        'MenuItem313
        '
        Me.MenuItem313.Index = 1
        Me.MenuItem313.Text = "-"
        '
        'MenuItem314
        '
        Me.MenuItem314.Index = 2
        Me.MenuItem314.Text = "&2.- Depreciar Activos"
        '
        'MenuItem312
        '
        Me.MenuItem312.Index = 3
        Me.MenuItem312.Text = "&3.- Cierre de A�o"
        '
        'MenuItem177
        '
        Me.MenuItem177.Index = 2
        Me.MenuItem177.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem315, Me.MenuItem316, Me.MenuItem317, Me.MenuItem322, Me.MenuItem318, Me.MenuItem319, Me.MenuItem320, Me.MenuItem323, Me.MenuItem321})
        Me.MenuItem177.Text = "Re&portes/Consultas"
        '
        'MenuItem315
        '
        Me.MenuItem315.Index = 0
        Me.MenuItem315.Text = "&1.- Inventario de Activos"
        '
        'MenuItem316
        '
        Me.MenuItem316.Index = 1
        Me.MenuItem316.Text = "&2.- Activos Fuera Inventario"
        '
        'MenuItem317
        '
        Me.MenuItem317.Index = 2
        Me.MenuItem317.Text = "&3.- Relaci�n D�bito/Cr�dito"
        '
        'MenuItem322
        '
        Me.MenuItem322.Index = 3
        Me.MenuItem322.Text = "-"
        '
        'MenuItem318
        '
        Me.MenuItem318.Index = 4
        Me.MenuItem318.Text = "&4.- Marcas"
        '
        'MenuItem319
        '
        Me.MenuItem319.Index = 5
        Me.MenuItem319.Text = "&5.- Localizaciones"
        '
        'MenuItem320
        '
        Me.MenuItem320.Index = 6
        Me.MenuItem320.Text = "&6.- Grupos de Activos"
        '
        'MenuItem323
        '
        Me.MenuItem323.Index = 7
        Me.MenuItem323.Text = "-"
        '
        'MenuItem321
        '
        Me.MenuItem321.Index = 8
        Me.MenuItem321.Text = "&7.- Sucursales"
        '
        'MenuItem178
        '
        Me.MenuItem178.Index = 3
        Me.MenuItem178.Text = "&Ayuda"
        '
        'MenuItem179
        '
        Me.MenuItem179.Index = 4
        Me.MenuItem179.Text = "&Salida"
        '
        'adm
        '
        Me.adm.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem335, Me.MenuItem338, Me.MenuItem341})
        '
        'MenuItem335
        '
        Me.MenuItem335.Index = 0
        Me.MenuItem335.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem336, Me.MenuItem337, Me.MenuItem339, Me.MenuItem342, Me.MenuItem343, Me.MenuItem348, Me.MenuItem349, Me.MenuItem350, Me.MenuItem351, Me.MenuItem352})
        Me.MenuItem335.Text = "&Registros"
        '
        'MenuItem336
        '
        Me.MenuItem336.Index = 0
        Me.MenuItem336.Text = "&1.- Host"
        '
        'MenuItem337
        '
        Me.MenuItem337.Index = 1
        Me.MenuItem337.Text = "&2.- M�dulos"
        '
        'MenuItem339
        '
        Me.MenuItem339.Index = 2
        Me.MenuItem339.Text = "&3.- Perfiles"
        '
        'MenuItem342
        '
        Me.MenuItem342.Index = 3
        Me.MenuItem342.Text = "&4.- Usuarios"
        '
        'MenuItem343
        '
        Me.MenuItem343.Index = 4
        Me.MenuItem343.Text = "&5.- Empresas"
        '
        'MenuItem348
        '
        Me.MenuItem348.Index = 5
        Me.MenuItem348.Text = "&6.- Paises"
        '
        'MenuItem349
        '
        Me.MenuItem349.Index = 6
        Me.MenuItem349.Text = "&7.- Provincias"
        '
        'MenuItem350
        '
        Me.MenuItem350.Index = 7
        Me.MenuItem350.Text = "&8.- Municipios"
        '
        'MenuItem351
        '
        Me.MenuItem351.Index = 8
        Me.MenuItem351.Text = "&9.- Sectores"
        '
        'MenuItem352
        '
        Me.MenuItem352.Index = 9
        Me.MenuItem352.Text = "&0.- Nacionalidades"
        '
        'MenuItem338
        '
        Me.MenuItem338.Index = 1
        Me.MenuItem338.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem376, Me.MenuItem534, Me.MenuItem377, Me.MenuItem471, Me.MenuItem472, Me.MenuItem481, Me.MenuItem482, Me.MenuItem576, Me.MenuItem577})
        Me.MenuItem338.Text = "&Parametros"
        '
        'MenuItem376
        '
        Me.MenuItem376.Index = 0
        Me.MenuItem376.Text = "&Inventario"
        '
        'MenuItem534
        '
        Me.MenuItem534.Index = 1
        Me.MenuItem534.Text = "Cuenta por Pagar"
        '
        'MenuItem377
        '
        Me.MenuItem377.Index = 2
        Me.MenuItem377.Text = "&Monedas"
        '
        'MenuItem471
        '
        Me.MenuItem471.Index = 3
        Me.MenuItem471.Text = "-"
        '
        'MenuItem472
        '
        Me.MenuItem472.Index = 4
        Me.MenuItem472.Text = "Comprobantes Fiscales"
        '
        'MenuItem481
        '
        Me.MenuItem481.Index = 5
        Me.MenuItem481.Text = "-"
        '
        'MenuItem482
        '
        Me.MenuItem482.Index = 6
        Me.MenuItem482.Text = "Visor de Sucesos"
        '
        'MenuItem576
        '
        Me.MenuItem576.Index = 7
        Me.MenuItem576.Text = "-"
        '
        'MenuItem577
        '
        Me.MenuItem577.Index = 8
        Me.MenuItem577.Text = "Relacin Usuario Empresa"
        '
        'MenuItem341
        '
        Me.MenuItem341.Index = 2
        Me.MenuItem341.Text = "&Salida"
        '
        'Pentra
        '
        Me.Pentra.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pentra.Location = New System.Drawing.Point(0, 307)
        Me.Pentra.Name = "Pentra"
        Me.Pentra.Size = New System.Drawing.Size(1028, 16)
        Me.Pentra.TabIndex = 9
        Me.Pentra.Visible = False
        '
        'ani
        '
        Me.ani.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem419, Me.MenuItem432, Me.MenuItem440, Me.MenuItem503, Me.MenuItem504})
        '
        'MenuItem419
        '
        Me.MenuItem419.Index = 0
        Me.MenuItem419.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem420, Me.MenuItem421, Me.MenuItem422, Me.MenuItem423, Me.MenuItem424, Me.MenuItem430, Me.MenuItem433, Me.MenuItem436, Me.MenuItem473, Me.MenuItem474})
        Me.MenuItem419.Text = "&Registrar"
        '
        'MenuItem420
        '
        Me.MenuItem420.Index = 0
        Me.MenuItem420.Text = "&1.- Tipo de Animales"
        '
        'MenuItem421
        '
        Me.MenuItem421.Index = 1
        Me.MenuItem421.Text = "&2.- Tipo de Andar"
        '
        'MenuItem422
        '
        Me.MenuItem422.Index = 2
        Me.MenuItem422.Text = "&3.- Registro Animales"
        '
        'MenuItem423
        '
        Me.MenuItem423.Index = 3
        Me.MenuItem423.Text = "-"
        '
        'MenuItem424
        '
        Me.MenuItem424.Index = 4
        Me.MenuItem424.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem425, Me.MenuItem441, Me.MenuItem439})
        Me.MenuItem424.Text = "&4.- Inventario "
        '
        'MenuItem425
        '
        Me.MenuItem425.Index = 0
        Me.MenuItem425.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem426, Me.MenuItem427, Me.MenuItem428, Me.MenuItem429, Me.MenuItem431, Me.MenuItem434, Me.MenuItem435, Me.MenuItem437})
        Me.MenuItem425.Text = "&1.- Datos Generales"
        '
        'MenuItem426
        '
        Me.MenuItem426.Index = 0
        Me.MenuItem426.Text = "&1.- Marcas"
        '
        'MenuItem427
        '
        Me.MenuItem427.Index = 1
        Me.MenuItem427.Text = "&2.- Modelos"
        '
        'MenuItem428
        '
        Me.MenuItem428.Index = 2
        Me.MenuItem428.Text = "-"
        '
        'MenuItem429
        '
        Me.MenuItem429.Index = 3
        Me.MenuItem429.Text = "&3.- Unidades"
        '
        'MenuItem431
        '
        Me.MenuItem431.Index = 4
        Me.MenuItem431.Text = "-"
        '
        'MenuItem434
        '
        Me.MenuItem434.Index = 5
        Me.MenuItem434.Text = "&4.- Origen"
        '
        'MenuItem435
        '
        Me.MenuItem435.Index = 6
        Me.MenuItem435.Text = "&5.- Grupos"
        '
        'MenuItem437
        '
        Me.MenuItem437.Index = 7
        Me.MenuItem437.Text = "&6.- Clases"
        '
        'MenuItem441
        '
        Me.MenuItem441.Index = 1
        Me.MenuItem441.Text = "-"
        '
        'MenuItem439
        '
        Me.MenuItem439.Index = 2
        Me.MenuItem439.Text = "&2.- Registro de Consumos"
        '
        'MenuItem430
        '
        Me.MenuItem430.Index = 5
        Me.MenuItem430.Text = "-"
        '
        'MenuItem433
        '
        Me.MenuItem433.Index = 6
        Me.MenuItem433.Text = "&5.- Clientes"
        '
        'MenuItem436
        '
        Me.MenuItem436.Index = 7
        Me.MenuItem436.Text = "&6.- Suplidores"
        '
        'MenuItem473
        '
        Me.MenuItem473.Index = 8
        Me.MenuItem473.Text = "-"
        '
        'MenuItem474
        '
        Me.MenuItem474.Index = 9
        Me.MenuItem474.Text = "&7.- Dietas Predeterminadas"
        '
        'MenuItem432
        '
        Me.MenuItem432.Index = 1
        Me.MenuItem432.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem438, Me.MenuItem452, Me.MenuItem442, Me.MenuItem443, Me.MenuItem453, Me.MenuItem470, Me.MenuItem498, Me.MenuItem499, Me.MenuItem502, Me.MenuItem505})
        Me.MenuItem432.Text = "&Procesos"
        '
        'MenuItem438
        '
        Me.MenuItem438.Index = 0
        Me.MenuItem438.Text = "&1.-Movimientos de Consumos"
        '
        'MenuItem452
        '
        Me.MenuItem452.Index = 1
        Me.MenuItem452.Text = "-"
        '
        'MenuItem442
        '
        Me.MenuItem442.Index = 2
        Me.MenuItem442.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem444, Me.MenuItem451, Me.MenuItem445, Me.MenuItem446})
        Me.MenuItem442.Text = "&2.- Cuentas por Cobrar"
        '
        'MenuItem444
        '
        Me.MenuItem444.Index = 0
        Me.MenuItem444.Text = "&1.- Facturas por Cobrar"
        '
        'MenuItem451
        '
        Me.MenuItem451.Index = 1
        Me.MenuItem451.Text = "-"
        '
        'MenuItem445
        '
        Me.MenuItem445.Index = 2
        Me.MenuItem445.Text = "&2.- Cobros a Facturas"
        '
        'MenuItem446
        '
        Me.MenuItem446.Index = 3
        Me.MenuItem446.Text = "&3.- Notas a Facturas "
        '
        'MenuItem443
        '
        Me.MenuItem443.Index = 3
        Me.MenuItem443.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem447, Me.MenuItem450, Me.MenuItem448, Me.MenuItem449})
        Me.MenuItem443.Text = "&3.- Cuentas por Pagar"
        '
        'MenuItem447
        '
        Me.MenuItem447.Index = 0
        Me.MenuItem447.Text = "&1.- Facturas por Pagar"
        '
        'MenuItem450
        '
        Me.MenuItem450.Index = 1
        Me.MenuItem450.Text = "-"
        '
        'MenuItem448
        '
        Me.MenuItem448.Index = 2
        Me.MenuItem448.Text = "&2.- Pagos a Facturas"
        '
        'MenuItem449
        '
        Me.MenuItem449.Index = 3
        Me.MenuItem449.Text = "&3.- Notas a Facturas"
        '
        'MenuItem453
        '
        Me.MenuItem453.Index = 4
        Me.MenuItem453.Text = "-"
        '
        'MenuItem470
        '
        Me.MenuItem470.Index = 5
        Me.MenuItem470.Text = "&4.- Movimientos de Animales"
        '
        'MenuItem498
        '
        Me.MenuItem498.Index = 6
        Me.MenuItem498.Text = "-"
        '
        'MenuItem499
        '
        Me.MenuItem499.Index = 7
        Me.MenuItem499.Text = "&5.- Movimientos Pre��"
        '
        'MenuItem502
        '
        Me.MenuItem502.Index = 8
        Me.MenuItem502.Text = "-"
        '
        'MenuItem505
        '
        Me.MenuItem505.Index = 9
        Me.MenuItem505.Text = "&6.- Orden Compra"
        '
        'MenuItem440
        '
        Me.MenuItem440.Index = 2
        Me.MenuItem440.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem454, Me.MenuItem458, Me.MenuItem455, Me.MenuItem456, Me.MenuItem459, Me.MenuItem457, Me.MenuItem475, Me.MenuItem476, Me.MenuItem500, Me.MenuItem501})
        Me.MenuItem440.Text = "Re&portes/Consultas"
        '
        'MenuItem454
        '
        Me.MenuItem454.Index = 0
        Me.MenuItem454.Text = "&1.- Reporte de Consumos"
        '
        'MenuItem458
        '
        Me.MenuItem458.Index = 1
        Me.MenuItem458.Text = "-"
        '
        'MenuItem455
        '
        Me.MenuItem455.Index = 2
        Me.MenuItem455.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem460, Me.MenuItem464, Me.MenuItem461, Me.MenuItem462, Me.MenuItem463})
        Me.MenuItem455.Text = "&2.- Cuentas por Cobrar"
        '
        'MenuItem460
        '
        Me.MenuItem460.Index = 0
        Me.MenuItem460.Text = "&1.- Reporte de Clientes"
        '
        'MenuItem464
        '
        Me.MenuItem464.Index = 1
        Me.MenuItem464.Text = "-"
        '
        'MenuItem461
        '
        Me.MenuItem461.Index = 2
        Me.MenuItem461.Text = "&2.- Reporte de Facturas"
        '
        'MenuItem462
        '
        Me.MenuItem462.Index = 3
        Me.MenuItem462.Text = "&3.- Reporte de Pagos"
        '
        'MenuItem463
        '
        Me.MenuItem463.Index = 4
        Me.MenuItem463.Text = "&4.- Reporte de Notas"
        '
        'MenuItem456
        '
        Me.MenuItem456.Index = 3
        Me.MenuItem456.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem465, Me.MenuItem469, Me.MenuItem466, Me.MenuItem467, Me.MenuItem468})
        Me.MenuItem456.Text = "&3.- Cuentas por Pagar"
        '
        'MenuItem465
        '
        Me.MenuItem465.Index = 0
        Me.MenuItem465.Text = "&1.- Reporte de Suplidores"
        '
        'MenuItem469
        '
        Me.MenuItem469.Index = 1
        Me.MenuItem469.Text = "-"
        '
        'MenuItem466
        '
        Me.MenuItem466.Index = 2
        Me.MenuItem466.Text = "&2.- Reporte de Facturas"
        '
        'MenuItem467
        '
        Me.MenuItem467.Index = 3
        Me.MenuItem467.Text = "&3.- Reporte de Pagos"
        '
        'MenuItem468
        '
        Me.MenuItem468.Index = 4
        Me.MenuItem468.Text = "&4.- Reporte de Notas"
        '
        'MenuItem459
        '
        Me.MenuItem459.Index = 4
        Me.MenuItem459.Text = "-"
        '
        'MenuItem457
        '
        Me.MenuItem457.Index = 5
        Me.MenuItem457.Text = "&4.- Historial de Animales"
        '
        'MenuItem475
        '
        Me.MenuItem475.Index = 6
        Me.MenuItem475.Text = "-"
        '
        'MenuItem476
        '
        Me.MenuItem476.Index = 7
        Me.MenuItem476.Text = "&5.- Dietas Animales"
        '
        'MenuItem500
        '
        Me.MenuItem500.Index = 8
        Me.MenuItem500.Text = "-"
        '
        'MenuItem501
        '
        Me.MenuItem501.Index = 9
        Me.MenuItem501.Text = "&6.- Animales"
        '
        'MenuItem503
        '
        Me.MenuItem503.Index = 3
        Me.MenuItem503.Text = "&Ayuda"
        '
        'MenuItem504
        '
        Me.MenuItem504.Index = 4
        Me.MenuItem504.Text = "&Salida"
        '
        'Menu_principal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1028, 345)
        Me.Controls.Add(Me.Pentra)
        Me.Controls.Add(Me.s1)
        Me.Controls.Add(Me.tab1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.KeyPreview = True
        Me.Menu = Me.cxc
        Me.Name = "Menu_principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cuentas por Cobrar"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.tab1.ResumeLayout(False)
        CType(Me.p1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.p2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    Dim empresa_nom
    Dim empresa_rnc
    Dim empresa_dir
        Dim empresa_tel
        Dim sucur_n

    llamastring() 'llama la coneccion de la base de datos

    Dim frm As New Configuracion_Sistema.Coneccion
    frm.servidor_db = tser
    frm.base_db = tbas
    frm.usuario_db = tusu
    frm.password_db = tpas
    frm.tipdb = ttip
    frm = Nothing

    apagamodulos()
    Dim empre
    Dim sucur
    empre = 0 : sucur = ""
    Dim frm2 As New Entrada
    frm2.ShowDialog()
    If frm2.bcod.Text = "N" Then
      Timer1.Enabled = True
      Return
    Else
      usuario = Trim(frm2.usu.Text)
      empre = Val(frm2.empresa.Text)
      sucur = Trim(frm2.sucu.Text)
      frm2 = Nothing
    End If

    If empre = 0 Then
      Dim frm3 As New Seleccionar_Empresa
      frm3.ShowDialog()
      If frm3.bcod.Text = "" Then
        Timer1.Enabled = True
      End If
      empresa_nom = frm3.emp.Text
      id_empresa = frm3.bcod.Text
      empresa_dir = frm3.dir.Text
      empresa_rnc = frm3.rnc.Text
      empresa_tel = frm3.tel.Text
      frm3 = Nothing
    Else
      Dim db As New DataSet
      creadb("gen_empresas", "select * from gen_empresas where emp_codigo = " & empre, db)
      If db.Tables(0).Rows.Count > 0 Then
        empresa_nom = db.Tables(0).Rows(0)("emp_nombre")
        id_empresa = empre
        empresa_dir = db.Tables(0).Rows(0)("emp_direccion")
        empresa_rnc = db.Tables(0).Rows(0)("emp_rnc")
        empresa_tel = db.Tables(0).Rows(0)("emp_telefono")
      End If
      db = Nothing
        End If

        Dim suc_se As Boolean

        If sucur = "" Then
            Dim frm4 As New Seleccionar_Sucursal
            frm4.emp.Text = id_empresa
            frm4.ShowDialog()
            If frm4.bcod.Text = "" Then
                Timer1.Enabled = True
            End If
            sucur = Trim("" & frm4.bcod.Text)
            sucur_n = Trim("" & frm4.emp.Text)
            empresa_dir = Trim("" & frm4.dir.Text)
            empresa_tel = Trim("" & frm4.tel.Text)
            frm4 = Nothing
            suc_se = True
        Else
            suc_se = False
            Dim dbts As New DataSet
            creadb("gen_sucursales", "select * from gen_sucursales where emp_codigo = " & id_empresa & " and suc_codigo = '" & sucur & "'", dbts)
            If dbts.Tables(0).Rows.Count > 0 Then
                sucur_n = dbts.Tables(0).Rows(0)("suc_descripcion")
                empresa_dir = dbts.Tables(0).Rows(0)("suc_direccion")
                empresa_tel = dbts.Tables(0).Rows(0)("suc_telefono1")
            Else
                sucur_n = ""
            End If
            dbts = Nothing
        End If

        'esta es la empresa o sucursal seleccionada var public
        modulo = "CXC" 'este es el modulo seleccionado var public
        conecc(usuario, id_empresa, modulo) 'envia los datos para ser usados como publico
        datos_empresa(empresa_nom, empresa_dir, empresa_rnc, empresa_tel) 'envia los datos de la empresa para ser publicos
        datos_Sucursal(Trim("" & sucur), suc_se)
        s1.Text = empresa_nom
        iniciaagenda(emp_id(), sucur_n, empresa_nom) 'LOGO
        llamatipofac()
        'If Not Carga_Menu(usuario) Then Exit Sub 'Me.Close()
        tab1.SelectedIndex = 1
        suce(5, "Entrada al Sistema a la fecha " & Now, mod_id(), usu_id(), emp_id())

        If tipo_secci = "S" Then
            Dim MiForm As New Facturacion.Monitoreo__Habitaciones
            MiForm.MdiParent = Me
            MiForm.Show()
            MiForm = Nothing
        End If

  End Sub
  Private Sub llamatipofac()
    Dim dbs As New DataSet
    creadb("fac_parametros", "select * from fac_parametros where emp_codigo = " & emp_id(), dbs)
    If "" & dbs.Tables("fac_parametros").Rows(0)("par_modelo_factura") = "M" Then
      modelo_fac = "M"
    Else
      modelo_fac = "N"
    End If

    If Trim("" & dbs.Tables("fac_parametros").Rows(0)("par_secciones")) = "S" Then
      tipo_secci = "S"
    Else
      tipo_secci = "N"
    End If

    dbs = Nothing
  End Sub
    Private Sub iniciaagenda(ByVal empresa, ByVal sucursal, ByVal nombre)
        Dim MiForm As New logo
        MiForm.MdiParent = Me
        MiForm.empresa.Text = Trim(empresa) & " " & Trim(nombre)
        MiForm.sucursal.Text = Trim(sucursal)
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub llamastring()
        Dim archivo
        Dim linein
        Dim oread = System.IO.File.OpenText("ini.ini")
        linein = oread.ReadLine()
        tser = Trim(linein)
        linein = oread.ReadLine()
        tbas = Trim(linein)
        linein = oread.ReadLine()
        tusu = Trim(linein)
        linein = oread.ReadLine()
        tpas = Trim(linein)
        linein = oread.ReadLine()
        ttip = Trim(linein)
        oread.Close()
    End Sub

    Private Sub apagamodulos()
        Dim db As New DataSet
        creadb("adm_modulos", "select * from adm_modulos", db)
        Dim f
        f = 0

        Do While f <= db.Tables(0).Rows.Count - 1
            If db.Tables(0).Rows(f)("mod_instalado") <> "S" Then
                Select Case Trim("" & db.Tables(0).Rows(f)("mod_corte"))
                    Case "ACXC"
                        tab1.TabPages.Remove(acxc)
                    Case "ACXP"
                        tab1.TabPages.Remove(acxp)
                    Case "AACT"
                        tab1.TabPages.Remove(aact)
                    Case "ACNT"
                        tab1.TabPages.Remove(acnt)
                    Case "ANOM"
                        tab1.TabPages.Remove(anom)
                    Case "AINV"
                        tab1.TabPages.Remove(ainv)
                    Case "ABAN"
                        tab1.TabPages.Remove(aban)
                    Case "AFAC"
                        tab1.TabPages.Remove(afac)
                    Case "AADM"
                        tab1.TabPages.Remove(aadm)
                    Case "AANI"
                        tab1.TabPages.Remove(aani)

                End Select

            End If
            f = f + 1
        Loop
        db = Nothing
    End Sub

    Private Sub apagamodulosusuario(ByVal usu)
        On Error GoTo 99

        '*****************************************
        'inicio de transaccion para salvar

        Dim myconn
        myconn = conecta(myconn)
        Dim tran
        tran = initran(myconn)
        'fin inicio de transaccion
        '*****************************************
        Dim db2 As New DataSet
        creadbt("adm_modulos", "select * from adm_modulos left join  (select distinct adm_modulos.mod_codigo from adm_modulos  left join adm_grupos_detalle on adm_modulos.mod_codigo = adm_grupos_detalle.mod_codigo left join adm_usuarios on adm_grupos_detalle.gru_codigo = adm_usuarios.gru_codigo where  adm_modulos.mod_instalado = 'S' and adm_grupos_detalle.opc_enabled = true and usu_codigo = '" & Trim(usu) & "') x on adm_modulos.mod_codigo = x.mod_codigo where x.mod_codigo is null and adm_modulos.mod_instalado = 'S'", db2, myconn)
        Dim f
        f = 0

        Do While f <= db2.Tables(0).Rows.Count - 1
            If Trim("" & db2.Tables(0).Rows(f)("mod_instalado")) = "S" Then
                Select Case Trim(db2.Tables(0).Rows(f)("mod_corte"))
                    Case "ACXC"
                        tab1.TabPages.Remove(acxc)
                    Case "ACXP"
                        tab1.TabPages.Remove(acxp)
                    Case "AACT"
                        tab1.TabPages.Remove(aact)
                    Case "ACNT"
                        tab1.TabPages.Remove(acnt)
                    Case "ANOM"
                        tab1.TabPages.Remove(anom)
                    Case "AINV"
                        tab1.TabPages.Remove(ainv)
                    Case "ABAN"
                        tab1.TabPages.Remove(aban)
                    Case "AFAC"
                        tab1.TabPages.Remove(afac)
                    Case "AADM"
                        tab1.TabPages.Remove(aadm)
                End Select

            End If
            f = f + 1
        Loop

        fintran(tran)
        tran = Nothing
        myconn.close()
        myconn = Nothing
        db2 = Nothing
        Exit Sub
99:
        MsgBox(Err.Description, MsgBoxStyle.Critical, "Datasoft")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Close()
    End Sub

    Private Sub tab1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tab1.SelectedIndexChanged

        If (tab1.SelectedTab.AccessibleName) = "cxc" Then
            Me.Menu = cxc
            Me.Text = "Cuentas por Cobrar"
            modulo = "CXC"
        End If

        If (tab1.SelectedTab.AccessibleName) = "cxp" Then
            Me.Menu = cxp
            Me.Text = "Cuentas por Pagar"
            modulo = "CXP"
        End If

        If (tab1.SelectedTab.AccessibleName) = "inv" Then
            Me.Menu = inv
            Me.Text = "Inventario de Mercancias"
            modulo = "INV"
        End If
        If (tab1.SelectedTab.AccessibleName) = "ban" Then
            Me.Menu = ban
            Me.Text = "Bancos"
            modulo = "BAN"
        End If
        If (tab1.SelectedTab.AccessibleName) = "cnt" Then
            Me.Menu = cnt
            Me.Text = "Contabilidad General"
            modulo = "CNT"
        End If
        If (tab1.SelectedTab.AccessibleName) = "nom" Then
            Me.Menu = nom
            Me.Text = "N�mina de Empleados"
            modulo = "NOM"
        End If
        If (tab1.SelectedTab.AccessibleName) = "act" Then
            Me.Menu = act
            Me.Text = "Activos Fijos"
            modulo = "ACT"
        End If
        If (tab1.SelectedTab.AccessibleName) = "fac" Then
            Me.Menu = fac
            Me.Text = "Facturaci�n"
            modulo = "FAC"
        End If
        If (tab1.SelectedTab.AccessibleName) = "adm" Then
            Me.Menu = adm
            Me.Text = "Administrador del Sistema"
            modulo = "ADM"
        End If
        If (tab1.SelectedTab.AccessibleName) = "ani" Then
            Me.Menu = ani
            Me.Text = "Control de Animales"
            modulo = "ANI"
        End If


        conecc(usu_id, emp_id(), modulo) 'envia los datos para ser usados como publico
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Me.Close()
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim MiForm As New Registro_de_zonas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem17.Click
        Dim MiForm As New Registro_de_Sucursales
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem18.Click
        Dim MiForm As New Registro_de_Condiciones
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Dim MiForm As New Registro_Tipos_Vendedores
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
        Dim MiForm As New Registro_de_Tipos_Clientes
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub



    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Dim MiForm As New Registro_de_Tipos_de_Envios
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim MiForm As New Registro_de_Rango
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem33_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem33.Click
        Dim MiForm As New Registro_de_Vendedores
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Dim MiForm As New Registro_de_Clientes
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Dim MiForm As New Registro_de_Tipos_de_Servicios
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem5.Click
        Dim MiForm As New Proceso_de_facturas_de_Servicios
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
        Dim MiForm As New Proceso_Pagos_Facturas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub



    Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
        Dim MiForm As New Proceso_Nota_Facturas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
        Dim MiForm As New Proceso_anticipos_facturas_
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem6.Click
        Dim MiForm As New Proceso_Facturas_Lote
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
        rep_fil_cli("Reporte de Clientes", "Reporte de Clientes.rpt", 0, "")
    End Sub

    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem42.Click
        rep_fil_cli("Balance Actuales", "Reporte balance actuales.rpt", 0, "({cxc_clientes.cli_balance_cxc} <> 0 or {cxc_clientes.cli_balance_anticipo} <> 0)")
    End Sub
    Private Sub rep_fil_cli(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String)
        Dim MiForm As New Filtro_de_Clientes
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {cxc_clientes.emp_codigo} = " & emp_id()
        Else
            opc = "{cxc_clientes.emp_codigo} = " & emp_id()
        End If

        MiForm.Filtro.Text = opc

        If rfec = 0 Then
            MiForm.rfec.Enabled = False
            MiForm.rfec.Text = ""
        End If
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_vis(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String)
        Dim MiForm As New Filtro_Visitas_Movil
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {cxc_clientes.emp_codigo} = " & emp_id()
        Else
            opc = "{cxc_clientes.emp_codigo} = " & emp_id()
        End If

        MiForm.Filtro.Text = opc

        ' If rfec = 0 Then
        '  MiForm.rfec.Enabled = False
        '  MiForm.rfec.Text = ""
        '  End If

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_sup(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String)
        Dim MiForm As New Filtro_de_suplidores
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {cxp_suplidores.emp_codigo} = " & emp_id()
        Else
            opc = "{cxp_suplidores.emp_codigo} = " & emp_id()
        End If

        MiForm.Filtro.Text = opc

        If rfec = 0 Then
            MiForm.rfec.Enabled = False
            MiForm.rfec.Text = ""
        End If
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_doc_banco(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String)
        Dim MiForm As New Filtro_de_documentos
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {ban_movimientos.emp_codigo} = " & emp_id()
        Else
            opc = "{ban_movimientos.emp_codigo} = " & emp_id()
        End If
        If rfec = 0 Then
            MiForm.b10.Enabled = False
        End If
        MiForm.Filtro.Text = opc

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_activos(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String)
        Dim MiForm As New Filtro_de_activos
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {act_activos.emp_codigo} = " & emp_id()
        Else
            opc = "{act_activos.emp_codigo} = " & emp_id()
        End If
        If rfec = 0 Then

        End If
        MiForm.Filtro.Text = opc

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_activos_mov(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String)
        Dim MiForm As New Filtro_Movimientos_act
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {act_movimientos.emp_codigo} = " & emp_id()
        Else
            opc = "{act_movimientos.emp_codigo} = " & emp_id()
        End If
        If rfec = 0 Then

        End If
        MiForm.Filtro.Text = opc

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_doc_cnt(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String)
        Dim MiForm As New Filtro_de_documentos_cnt
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {con_movimientos.emp_codigo} = " & emp_id()
        Else
            opc = "{con_movimientos.emp_codigo} = " & emp_id()
        End If
        MiForm.Filtro.Text = opc

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_bal_cnt(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String, ByVal fe As Boolean, ByVal totales As Boolean)
        Dim MiForm As New Filtro_de_balance_cnt
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {con_cuentas.emp_codigo} = " & emp_id()
        Else
            opc = "{con_cuentas.emp_codigo} = " & emp_id()
        End If
        If fe = True Then
            MiForm.fe.Text = "S"
        Else
            MiForm.fe.Text = "N"
        End If
        If totales = True Then
            MiForm.totales.Text = "S"
        Else
            MiForm.totales.Text = "N"
        End If
        MiForm.Filtro.Text = opc

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_bal_cnt2(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String, ByVal fe As Boolean)
        Dim MiForm As New Filtro_mayor_cnt
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {con_cuentas.emp_codigo} = " & emp_id()
        Else
            opc = "{con_cuentas.emp_codigo} = " & emp_id()
        End If
        If fe = True Then
            MiForm.fe.Text = "S"
        Else
            MiForm.fe.Text = "N"
        End If
        MiForm.Filtro.Text = opc

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_estado_cnt(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String, ByVal fe As Boolean)
        Dim MiForm As New filtro_estado_cnt
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {con_cuentas.emp_codigo} = " & emp_id()
        Else
            opc = "{con_cuentas.emp_codigo} = " & emp_id()
        End If
        If fe = True Then
            MiForm.fe.Text = "S"
        Else
            MiForm.fe.Text = "N"
        End If
        MiForm.Filtro.Text = opc

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_cuentas_cnt(ByVal tfil As String, ByVal rep As String, ByVal rfec As Integer, ByVal opc As String, ByVal fe As Boolean)
        Dim MiForm As New Filtro_cuentas_cnt
        MiForm.Text = tfil
        MiForm.rep.Text = rep

        If opc <> "" Then
            opc = opc & " and {con_cuentas.emp_codigo} = " & emp_id()
        Else
            opc = "{con_cuentas.emp_codigo} = " & emp_id()
        End If
        MiForm.Filtro.Text = opc
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub rep_fil_fac(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New Filtro_Facturas
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep

        MiForm.Filtro.Text = "{cxc_facturas.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_fac_cxp(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New Filtro_Facturas_cxp
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep

        If rfec <> "" Then
            MiForm.Filtro.Text = "{cxp_facturas.emp_codigo} = " & emp_id() & " and " & rfec
        Else
            MiForm.Filtro.Text = "{cxp_facturas.emp_codigo} = " & emp_id()
        End If

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_pag(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New Filtro_pagos
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{cxc_pagos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_pag_cxp(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New Filtro_pagos_cxp
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{cxp_pagos.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_not(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New filtro_notas
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{cxc_notas.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_not_cxp(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New filtro_notas_cxp
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{cxp_notas.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_ant(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New Filtro_de_Anticipos
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{cxc_anticipos.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_ant_cxp(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New Filtro_de_Anticipos_cxp
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{cxp_anticipos.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_gen(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New filtro_General
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{gen_empresas.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_gen_cxp(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New filtro_General_cxp
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{gen_empresas.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub rep_fil_gen_nom(ByVal tfil As String, ByVal rep As String, ByVal rfec As String, ByVal emp As Boolean)
        Dim MiForm As New Filtro_General_Nom
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        If emp Then
            MiForm.Filtro.Text = "{gen_empresas.emp_codigo} = " & emp_id()
        Else
            MiForm.Filtro.Text = ""
        End If
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_mov_fac(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New Filtro_de_Movimientos
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep

        MiForm.Filtro.Text = "{fac_ventas.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Private Sub rep_fil_mov_fac_com(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New filtro_comisiones_fac
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{fac_ventas.emp_codigo} = " & emp_id()
        'MiForm.Filtro.Text = "{fac_ventas.emp_codigo} = " & emp_id() & " and (({fac_ventas.cxc_impuesto_peso} <= 0.001) or ({fac_ventas.fac_credito} <= 0.001))"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub rep_fil_mov_fac2(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New Filtro_de_Movimientos_de_Secciones
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep

        MiForm.Filtro.Text = "{fac_ventas.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub rep_fil_gen_Fac(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New Filtro_General_Fac
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{gen_empresas.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_egr_fac(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New filtro_de_egresos_fac
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep

        MiForm.Filtro.Text = "{fac_egresos.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem1.Click

    End Sub

    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        rep_fil_fac("Facturas Pendientes", "Reporte facturas pendientes.rpt", "{@balance} > 0")
    End Sub

    Private Sub MenuItem92_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem92.Click
        rep_fil_pag("Pagos detallados", "Reporte Pagos a Factura detallado.rpt", "{@total} > 0")
    End Sub

    Private Sub MenuItem94_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem94.Click
        rep_fil_pag("Pagos Totalizado", "Reporte Pagos a Factura totalizado.rpt", "{@total} > 0")
    End Sub

    Private Sub MenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem70.Click
        rep_fil_fac("Facturas Por clientes", "Reporte facturas por clientes.rpt", "")
    End Sub

    Private Sub MenuItem71_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem71.Click
        rep_fil_fac("Facturas Por Vendedores", "Reporte facturas por vendedores.rpt", "")
    End Sub

    Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem72.Click
        rep_fil_fac("Facturas Por Zonas", "Reporte facturas por zonas.rpt", "")
    End Sub

    Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem74.Click
        rep_fil_fac("Facturas Por Sucursal", "Reporte facturas por Sucursal.rpt", "")
    End Sub

    Private Sub MenuItem75_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem75.Click
        rep_fil_fac("Facturas Por Tipo", "Reporte facturas por tipo.rpt", "")
    End Sub

    Private Sub MenuItem79_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem79.Click
        rep_fil_fac("Facturas Por Totalizadas por Cliente", "Reporte facturas por clientes totalizado.rpt", "")
    End Sub

    Private Sub MenuItem80_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem80.Click
        rep_fil_fac("Facturas Por Vendedores", "Reporte facturas por vendedores totalizadas.rpt", "")
    End Sub

    Private Sub MenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem81.Click
        rep_fil_fac("Facturas Por Zonas", "Reporte facturas por zonas totalizados.rpt", "")
    End Sub

    Private Sub MenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem82.Click
        rep_fil_fac("Facturas Por Sucursal", "Reporte facturas por sucursal totalizadas.rpt", "")
    End Sub

    Private Sub MenuItem83_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem83.Click
        rep_fil_fac("Facturas Por Tipo", "Reporte facturas por tipo totalizada.rpt", "")
    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        rep_fil_not("Notas detalladas", "Reporte notas a Factura detallado.rpt", "")
    End Sub

    Private Sub MenuItem97_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem97.Click
        rep_fil_not("Notas Totalizadas", "Reporte notas a Factura totalizado.rpt", "")
    End Sub

    Private Sub MenuItem98_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem98.Click
        rep_fil_ant("Anticipos Detallados", "Reporte de anticipos detallados.rpt", "")
    End Sub

    Private Sub MenuItem100_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem100.Click
        rep_fil_ant("Anticipos Aplicados", "Reporte de anticipos Aplicados.rpt", "")
    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        rep_fil_gen("Vendedores Registrados", "Reporte de vendedores.rpt", "")
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        rep_fil_gen("Zonas Registradas", "Reporte de zonas.rpt", "")
    End Sub

    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click
        rep_fil_gen("Servicios Registrados", "Reporte de Servicios.rpt", "")
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        rep_fil_gen("Tipos de Clientes", "Reporte de tipos de clientes.rpt", "")
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        rep_fil_gen("Tipos de Vendedores", "Reporte de tipos de Vendedores.rpt", "")
    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        rep_fil_gen("Tipos de Envios", "Reporte de tipos de Envios.rpt", "")
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        rep_fil_gen("Rango Comisiones", "Reporte de rango comisiones.rpt", "")
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        rep_fil_gen("Sucursales", "Reporte de sucursales.rpt", "")
    End Sub

    Private Sub MenuItem101_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem101.Click
        Dim MiForm As New Filtro_antiguedad
        MiForm.tipo.Text = "T"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem103_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem103.Click
        Dim MiForm As New Filtro_antiguedad
        MiForm.tipo.Text = "V"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem95_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem95.Click
        Dim MiForm As New Filtro_Historico
        MiForm.tipo.Text = "V"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click

    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        Me.Close()
    End Sub

    Private Sub MenuItem114_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem114.Click
        rep_fil_sup("Reporte de Suplidores", "Reporte de Suplidores.rpt", 0, "")
    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem9.Click
        Dim MiForm As New Registro_de_zonas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem10.Click
        Dim MiForm As New Registro_de_Sucursales
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem104_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem104.Click
        Dim MiForm As New Registro_de_Condiciones_cxp
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem105_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem105.Click
        Dim MiForm As New Registro_de_Suplidores
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem126_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem126.Click
        Dim MiForm As New Registro_de_Tipos_Suplidores
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem11.Click
        Dim MiForm As New Proceso_de_facturas_cxp
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem111_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem111.Click
        Dim MiForm As New Proceso_anticipos_facturas_Cxp
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem109_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem109.Click
        Dim MiForm As New Proceso_Pagos_Facturas_cxp
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem110_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem110.Click
        Dim MiForm As New Proceso_Nota_Facturas_cxp
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem115_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem115.Click
        rep_fil_sup("Reporte de Balance CxP", "Reporte de balances cxp.rpt", 0, "({cxp_suplidores.sup_balance_cxp} <> 0 or {cxp_suplidores.sup_balance_anticipo} <> 0)")
    End Sub

    Private Sub MenuItem117_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem117.Click
        rep_fil_fac_cxp("Facturas por Pagar", "Reporte facturas por pagar.rpt", "{@balance} > 0")
    End Sub

    Private Sub MenuItem119_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem119.Click
        rep_fil_pag_cxp("Pagos Detallados", "Reporte Pagos a Factura detallado cxp.rpt", "{@total} > 0")
    End Sub

    Private Sub MenuItem121_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem121.Click
        rep_fil_pag_cxp("Pagos Totalizados", "Reporte Pagos a Factura totalizado cxp.rpt", "{@total} > 0")
    End Sub

    Private Sub MenuItem125_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem125.Click
        rep_fil_gen_cxp("Condiciones CxP", "Reporte de condiciones cxp.rpt", "")
    End Sub

    Private Sub MenuItem134_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem134.Click
        rep_fil_gen_cxp("Tipos de Suplidores", "Reporte de tipos cxp.rpt", "")
    End Sub

    Private Sub MenuItem138_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem138.Click

    End Sub

    Private Sub MenuItem139_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem139.Click
        rep_fil_fac_cxp("Facturas detalladas por Suplidor", "Reporte facturas detalladas por suplidor.rpt", "")
    End Sub

    Private Sub MenuItem141_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem141.Click
        rep_fil_fac_cxp("Facturas detalladas por Zona", "Reporte facturas detalladas por zonas.rpt", "")
    End Sub

    Private Sub MenuItem142_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem142.Click
        rep_fil_fac_cxp("Facturas detalladas por Sucursal", "Reporte facturas detalladas por sucursales.rpt", "")
    End Sub

    Private Sub MenuItem146_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem146.Click
        rep_fil_fac_cxp("Facturas Totalizadas por Suplidor", "Reporte facturas totalizadas por suplidor.rpt", "")
    End Sub

    Private Sub MenuItem148_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem148.Click
        rep_fil_fac_cxp("Facturas Totalizadas por Zona", "Reporte facturas totalizadas por zonas.rpt", "")
    End Sub

    Private Sub MenuItem149_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem149.Click
        rep_fil_fac_cxp("Facturas totalizada por Sucursal", "Reporte facturas totalizadas por sucursales.rpt", "")
    End Sub

    Private Sub MenuItem153_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem153.Click
        rep_fil_not_cxp("Notas detalladas", "Reporte de notas cxp detalladas.rpt", "")
    End Sub

    Private Sub MenuItem155_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem155.Click
        rep_fil_not_cxp("Notas Totalizadas", "Reporte de notas cxp totalizadas.rpt", "")
    End Sub

    Private Sub MenuItem157_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem157.Click
        rep_fil_ant_cxp("Anticipos Detallados", "Reporte de anticipos cxp detallados.rpt", "")
    End Sub

    Private Sub MenuItem159_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem159.Click
        rep_fil_ant_cxp("Anticipos Aplicados", "Reporte de anticipos cxp aplicados.rpt", "")
    End Sub

    Private Sub MenuItem162_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem162.Click
        Dim MiForm As New Filtro_antiguedad_cxp
        MiForm.tipo.Text = "T"
        MiForm.tip.Text = "F"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem164_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem164.Click
        Dim MiForm As New Filtro_antiguedad_cxp
        MiForm.tipo.Text = "V"
        MiForm.tip.Text = "F"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem165_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem165.Click
        Dim MiForm As New Filtro_Historico_cxp
        MiForm.tipo.Text = "V"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem27.Click
        Me.Close()
    End Sub

    Private Sub MenuItem131_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem131.Click
        Me.Close()
    End Sub

    Private Sub MenuItem147_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem147.Click
        Me.Close()
    End Sub

    Private Sub MenuItem169_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem169.Click
        Me.Close()
    End Sub

    Private Sub MenuItem174_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem174.Click
        Me.Close()
    End Sub

    Private Sub MenuItem179_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem179.Click
        Me.Close()
    End Sub

    Private Sub MenuItem180_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem180.Click
        Dim MiForm As New Registro_de_Cuentas_malas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem182_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem182.Click
        Dim MiForm As New Registro_de_zonas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem181_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem181.Click
        Dim MiForm As New Registro_de_Clientes
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem183_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem183.Click
        Dim MiForm As New Registro_de_Vendedores
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem193_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem193.Click
        Dim MiForm As New Registro_de_Cajas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem186_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem186.Click
        Dim MiForm As New proceso_de_facturacion
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing

        'If modelo_fac = "N" Then
        '    Dim MiForm As New proceso_de_facturacion
        '    MiForm.MdiParent = Me
        '    MiForm.Show()
        '    MiForm = Nothing
        'Else
        '    If modelo_fac = "M" Then
        '        Dim MiForm As New Proceso_facturacion_metraje
        '        MiForm.MdiParent = Me
        '        MiForm.Show()
        '        MiForm = Nothing
        '    End If
        'End If
    End Sub

    Private Sub MenuItem195_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem195.Click
        Dim MiForm As New Proceso_Egreso_de_Caja
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem187_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem187.Click
        Dim MiForm As New Proceso_Pagos_Facturas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem189_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem189.Click
        Dim MiForm As New Proceso_Nota_Facturas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem196_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem196.Click
        rep_fil_cli("Balance Actuales", "Reporte balance actuales.rpt", 0, "({cxc_clientes.cli_balance_cxc} <> 0 or {cxc_clientes.cli_balance_anticipo} <> 0)")
    End Sub

    Private Sub MenuItem197_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem197.Click
        rep_fil_fac("Facturas Pendientes", "Reporte facturas pendientes.rpt", "{@balance} > 0")
    End Sub

    Private Sub MenuItem199_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem199.Click
        rep_fil_pag("Pagos detallados", "Reporte Pagos a Factura detallado.rpt", "{@total} > 0")
    End Sub

    Private Sub MenuItem201_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem201.Click
        rep_fil_pag("Pagos Totalizado", "Reporte Pagos a Factura totalizado.rpt", "{@total} > 0")
    End Sub

    Private Sub MenuItem203_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem203.Click
        rep_fil_not("Notas detalladas", "Reporte notas a Factura detallado.rpt", "")
    End Sub

    Private Sub MenuItem205_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem205.Click
        rep_fil_not("Notas Totalizadas", "Reporte notas a Factura totalizado.rpt", "")
    End Sub

    Private Sub MenuItem207_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem207.Click
        rep_fil_ant("Anticipos Detallados", "Reporte de anticipos detallados.rpt", "")
    End Sub

    Private Sub MenuItem209_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem209.Click
        rep_fil_ant("Anticipos Aplicados", "Reporte de anticipos Aplicados.rpt", "")
    End Sub

    Private Sub MenuItem192_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem192.Click

    End Sub

    Private Sub MenuItem202_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem202.Click

    End Sub

    Private Sub MenuItem210_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem210.Click
        rep_fil_egr_fac("Egresos de Caja", "Reporte de egresos fac.rpt", "")
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem14.Click
        'Dim frm As New prueba_impresion_matricial
        'frm.ShowDialog()
        'frm = Nothing
        tab1.Visible = False
        tab1.Refresh()
    End Sub

    Private Sub MenuItem221_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem221.Click

    End Sub

    Private Sub MenuItem211_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem211.Click
        Dim MiForm As New Registro_de_tipos_ban
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem213_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem213.Click
        Dim MiForm As New Registro_de_cuentas_banco
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem216_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem216.Click
        Dim MiForm As New Proceso_Operaciones_Bancarias
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem215_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem215.Click
        Dim MiForm As New Registro_de_secuencias_banco
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem217_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem217.Click
        Dim MiForm As New proceso_de_cotejo_bancos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem218_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem218.Click
        Dim MiForm As New Proceso_de_Conciliacion_banco
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem219_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem219.Click
        rep_fil_doc_banco("Reporte de Operaciones Banco", "Reporte de movimientos banco.rpt", 0, "")
    End Sub

    Private Sub MenuItem227_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem227.Click
        rep_fil_doc_banco("Reporte de Operaciones Banco", "Reporte de movimientos banco con bene.rpt", 0, "")
    End Sub
    Private Sub rep_fil_gen_banco(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New filtro_General_banco
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{gen_empresas.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_gen_act(ByVal tfil As String, ByVal rep As String, ByVal rfec As String)
        Dim MiForm As New filtro_General_act
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        MiForm.Filtro.Text = "{gen_empresas.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub rep_fil_gen_Inv(ByVal tfil As String, ByVal rep As String, ByVal rfec As String, ByVal empr As Boolean)
        Dim MiForm As New Filtro_General_Inv
        MiForm.Text = tfil
        MiForm.opcional.Text = rfec
        MiForm.rep.Text = rep
        If empr = True Then MiForm.Filtro.Text = "{gen_empresas.emp_codigo} = " & emp_id() Else MiForm.Filtro.Text = ""
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem223_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem223.Click
        rep_fil_gen_banco("Cuentas de banco", "Reporte de cuentas banco.rpt", "")
    End Sub

    Private Sub MenuItem224_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem224.Click
        rep_fil_doc_banco("Historico de Transitos", "Reporte de historico de transitos.rpt", 1, "")
    End Sub

    Private Sub MenuItem222_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem222.Click
        Dim MiForm As New Filtro_Historico_banco
        MiForm.tipo.Text = "V"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem191_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem191.Click
        Dim MiForm As New Proceso_cuadrar_caja_fac
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem228_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem228.Click
        Dim MiForm As New Registro_de_tipos_cnt
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem230_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem230.Click
        Dim MiForm As New Registro_de_Cuentas_cnt
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem231_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem231.Click
        Dim MiForm As New Registro_de_Clasificacion_cnt
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem232_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem232.Click
        Dim MiForm As New Procesos_Movimientos_Cnt
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem234_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem234.Click

    End Sub

    Private Sub MenuItem235_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem235.Click
        Dim MiForm As New cierre_de_ano
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem236_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem236.Click
        rep_fil_doc_cnt("Reporte de Diario General", "Reporte de diario cnt.rpt", 0, "")
    End Sub

    Private Sub MenuItem246_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem246.Click
        rep_fil_bal_cnt("Reporte de Balance de Comprobaci�n", "Reporte de balance de comprobacion.rpt", 0, "({@debito} <>  '' or {@creditos} <>  '')", False, True)
    End Sub

    Private Sub MenuItem248_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem248.Click
        rep_fil_bal_cnt("Reporte de Balance de Comprobaci�n", "Reporte de balance de comprobacion comparado.rpt", 0, "({@debito} <>  '' or {@creditos} <>  '' or {@creditoant} <> 0 or {@debitoant} <> 0 or {@debitoa} <> 0 or {@creditoa} <> 0 )", False, True)
    End Sub

    Private Sub MenuItem249_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem249.Click
        Dim MiForm As New Registro_de_Marcas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem30.Click
        Dim MiForm As New Registro_de_articulos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem250_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem250.Click
        Dim MiForm As New Registro_de_Modelos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem252_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem252.Click
        Dim MiForm As New Registro_de_Unidades
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem253_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem253.Click
        Dim MiForm As New Registro_de_Precio
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem255_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem255.Click
        Dim MiForm As New Registro_de_Itbis
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem256_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem256.Click
        Dim MiForm As New Registro_de_Origen
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem257_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem257.Click
        Dim MiForm As New Registro_de_Grupos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem258_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem258.Click
        Dim MiForm As New Registro_de_Periodos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        Dim MiForm As New Registro_de_Departamentos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
        Dim MiForm As New Registro_Almacen
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        Dim MiForm As New Registro_de_Tipomovi
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
        rep_fil_gen_Inv("Marcas Registradas", "Reporte de Marcas.rpt", "", True)
    End Sub

    Private Sub MenuItem259_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem259.Click
        rep_fil_gen_Inv("Modelos Registrados", "Reporte de Modelos.rpt", "", True)
    End Sub

    Private Sub MenuItem261_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem261.Click
        rep_fil_gen_Inv("Unidades Registradas", "Reporte de Unidades.rpt", "", False)
    End Sub

    Private Sub MenuItem262_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem262.Click
        rep_fil_gen_Inv("Tipo Precios Registrados", "Reporte de Precios.rpt", "", True)
    End Sub

    Private Sub MenuItem264_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem264.Click
        rep_fil_gen_Inv("Itbis Registrados", "Reporte de Itbis.rpt", "", True)
    End Sub

    Private Sub MenuItem265_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem265.Click
        rep_fil_gen_Inv("Origenes Registrados", "Reporte de Origenes.rpt", "", True)
    End Sub

    Private Sub MenuItem266_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem266.Click
        rep_fil_gen_Inv("Grupos Registrados", "Reporte de Grupos.rpt", "", True)
    End Sub

    Private Sub MenuItem267_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem267.Click
        rep_fil_gen_Inv("Periodos Registrados", "Reporte de Periodos.rpt", "", True)
    End Sub

    Private Sub MenuItem270_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem270.Click
        Dim MiForm As New Registro_de_Clases
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem268_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem268.Click
        rep_fil_gen_Inv("Clases Registradas", "Reporte de Clases.rpt", "", True)
    End Sub

    Private Sub MenuItem269_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem269.Click
        rep_fil_gen_Inv("Actividades Registradas", "Reporte de Actividades.rpt", "", True)
    End Sub

    Private Sub MenuItem271_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem271.Click
        Dim MiForm As New Registro_de_Actividad
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem274_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem274.Click
        rep_fil_gen_Inv("Departamentos Registrados", "Reporte de Departamentos.rpt", "", True)
    End Sub

    Private Sub MenuItem275_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem275.Click
        rep_fil_gen_Inv("Alamcenes Registrados", "Reporte de Almacenes.rpt", "", True)
    End Sub

    Private Sub MenuItem276_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem276.Click
        rep_fil_gen_Inv("Tipo Registrados", "Reporte de Tipo Movimientos.rpt", "", True)
    End Sub

    Private Sub MenuItem280_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem280.Click
        Dim MiForm As New filtro_antiguedad_actual
        MiForm.tipo.Text = "T"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem282_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem282.Click
        Dim MiForm As New filtro_antiguedad_actual
        MiForm.tipo.Text = "V"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem286_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem286.Click
        Dim MiForm As New Filtro_antiguedad_cxp
        MiForm.tipo.Text = "T"
        MiForm.tip.Text = "A"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem288_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem288.Click
        Dim MiForm As New Filtro_antiguedad_cxp
        MiForm.tipo.Text = "V"
        MiForm.tip.Text = "A"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem241_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem241.Click
        rep_fil_estado_cnt("Reporte de Estado de Cuenta", "Reporte de estado de cuenta.rpt", 0, "", True)
    End Sub

    Private Sub MenuItem237_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem237.Click
        rep_fil_bal_cnt2("Reporte de Mayor General", "Reporte de mayor general 2.rpt", 0, "", True)
    End Sub


    Private Sub MenuItem90_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem90.Click
        Dim MiForm As New Movimientos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem291_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem291.Click
        rep_fil_fac_cxp("Compras", "Reporte de compras.rpt", "")
    End Sub

    Private Sub MenuItem292_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem292.Click
        Dim MiForm As New Filtro_antiguedad_cxp
        MiForm.tipo.Text = "T"
        MiForm.tip.Text = "B"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem294_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem294.Click
        Dim MiForm As New Filtro_antiguedad
        MiForm.tipo.Text = "T"
        MiForm.tip.Text = "B"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem242_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem242.Click
        rep_fil_cuentas_cnt("Reporte de cuentas contabilidad", "Reporte de catalogo de cuentas.rpt", 0, "", False)
    End Sub

    Private Sub MenuItem88_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem88.Click
        Dim MiForm As New Proceso_Orden_Compra
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem89_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem89.Click
        Dim MiForm As New Procesar_Orden
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem297_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem297.Click
        Dim MiForm As New proceso_consiliar_auxiliar
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem106_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem106.Click
        Dim MiForm As New Registro_de_Departamentos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem298_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem298.Click
        Dim MiForm As New Procesar_Cotizacion
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem299_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem299.Click
        Dim MiForm As New Cierre_de_mes_cnt
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem301_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem301.Click
        Dim MiForm As New Proceso_quitar_cierre
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem302_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem302.Click
        Dim MiForm As New Registro_de_Localizaciones
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem309_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem309.Click
        Dim MiForm As New Registro_de_Suplidores
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem303_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem303.Click
        Dim MiForm As New Registro_de_Marcas_act
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem305_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem305.Click
        Dim MiForm As New Registro_de_Grupos_act
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem304_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem304.Click
        Dim MiForm As New Registro_de_Cuentas_cnt
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem307_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem307.Click
        Dim MiForm As New Registro_Activos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem311_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem311.Click
        Dim MiForm As New Proceso_movimientos_Act
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem327_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem327.Click
        Dim MiForm As New Filtro_de_Articulos
        MiForm.Text = "Reporte de Articulos"
        MiForm.rep.Text = "Reporte de Articulos.rpt"

        MiForm.Filtro.Text = "  {inv_articulos.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem328_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem328.Click
        Dim MiForm As New ExistenciaxAlmacen
        MiForm.Text = "Reporte de Existencia x Alamac�n"
        MiForm.rep.Text = "Reporte de Existencia x Alamacen.rpt"
        MiForm.Filtro.Text = "  {inv_articulos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem329_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem329.Click
        Dim MiForm As New ExistenciaxAlmacen
        MiForm.Text = "Reporte de Art�culos en Reorden"
        MiForm.rep.Text = "Reporte de Articulos Reorden.rpt"
        MiForm.tiprep = "REO"
        MiForm.Filtro.Text = "  {inv_articulos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem330_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem330.Click
        Dim MiForm As New ExistenciaxAlmacen
        MiForm.Text = "Reporte de Art�culos Sobre el M�ximo"
        MiForm.rep.Text = "Reporte de Articulos Maximo.rpt"
        MiForm.tiprep = "MAX"
        MiForm.Filtro.Text = "  {inv_articulos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem331_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem331.Click
        Dim MiForm As New Filtro_de_PrecioxUnidad
        MiForm.Text = "Reporte de Precio x Unidad"
        MiForm.rep.Text = "Reporte de PrecioxUnidad2.rpt"
        MiForm.Filtro.Text = "  inv_articulos.emp_codigo = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem332_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem332.Click
        Dim MiForm As New Filtros_de_TarjetaInventario
        MiForm.Text = "Reporte de Tarjeta de Inventario"
        MiForm.rep.Text = "Reporte Tarjeta de Inventario.rpt"
        MiForm.Filtro.Text = "  {inv_articulos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub



    Private Sub MenuItem325_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem325.Click
        Dim MiForm As New Filtros_de_Analisismovimientos
        MiForm.Text = "Reporte An�lisis de Movimientos"
        MiForm.rep.Text = "Reporte Analisis de Movimientos Detallado.rpt"
        MiForm.Filtro.Text = "  {inv_articulos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem326_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem326.Click
        Dim MiForm As New Filtros_de_Analisismovimientos
        MiForm.Text = "Reporte An�lisis de Movimientos"
        MiForm.rep.Text = "Reporte Analisis de Movimientos Resumen.rpt"
        MiForm.Filtro.Text = "  {inv_articulos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem314_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem314.Click
        Dim MiForm As New Depreciar_Activos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem312_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem312.Click
        Dim MiForm As New Procesos_cierre_ano_act
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem315_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem315.Click
        rep_fil_activos("Reporte de Activos Fijos", "Reporte de activos.rpt", 0, "{act_activos.est_codigo} = '1'")
    End Sub

    Private Sub MenuItem316_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem316.Click
        rep_fil_activos("Reporte de Activos Fuera", "Reporte salida activos.rpt", 0, "{act_activos.est_codigo} = '2'")
    End Sub

    Private Sub MenuItem321_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem321.Click
        rep_fil_gen_act("Sucursales", "Reporte de sucursales.rpt", "")
    End Sub

    Private Sub MenuItem318_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem318.Click
        rep_fil_gen_act("Marcas de Activos", "Reporte marcas.rpt", "")
    End Sub

    Private Sub MenuItem320_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem320.Click
        rep_fil_gen_act("Grupos de Activos", "Reporte de grupos act.rpt", "")
    End Sub

    Private Sub MenuItem319_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem319.Click
        rep_fil_gen_act("Localizaciones de Activos", "Reporte de localizaciones act.rpt", "")
    End Sub

    Private Sub MenuItem317_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem317.Click
        rep_fil_activos_mov("Relaci�n D�bitos/Cr�ditos", "Reporte de movimientos act.rpt", 0, "")
    End Sub

    Private Sub MenuItem334_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem334.Click
        Dim MiForm As New Generar_Archivo_Itbis
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Function Carga_Menu(ByVal usu) As Boolean
        On Error GoTo 99
        Carga_Menu = False
        Dim DSusu As New DataSet
        Dim conta
        Dim myconn
        Dim tran
        myconn = conecta(myconn)
        tran = initran(myconn)
        actmenu(cxc)
        If Not Valida_OPciones(usu, "CXC", cxc, myconn, tran) Then tab1.TabPages.Remove(acxc) Else modulo = "CXC"
        'If Valida_OPciones(usu, "CXC", cxc) Then modulo = "CXC"
        actmenu(cxp)
        If Not Valida_OPciones(usu, "CXP", cxp, myconn, tran) Then tab1.TabPages.Remove(acxp) Else modulo = "CXP"
        'If Valida_OPciones(usu, "CXP", cxp) Then modulo = "CXP"
        actmenu(inv)
        If Not Valida_OPciones(usu, "INV", inv, myconn, tran) Then tab1.TabPages.Remove(ainv) Else modulo = "INV"
        'If Valida_OPciones(usu, "INV", inv) Then modulo = "INV"
        actmenu(nom)
        If Not Valida_OPciones(usu, "NOM", nom, myconn, tran) Then tab1.TabPages.Remove(anom) Else modulo = "NOM"
        'If Valida_OPciones(usu, "NOM", nom) Then modulo = "NOM"
        actmenu(cnt)
        If Not Valida_OPciones(usu, "CNT", cnt, myconn, tran) Then tab1.TabPages.Remove(acnt) Else modulo = "CNT"
        'If Valida_OPciones(usu, "CNT", cnt) Then modulo = "CNT"
        actmenu(adm)
        If Not Valida_OPciones(usu, "ADM", adm, myconn, tran) Then tab1.TabPages.Remove(aadm) Else modulo = "ADM"
        'If Valida_OPciones(usu, "ADM", adm) Then modulo = "ADM"
        actmenu(act)
        If Not Valida_OPciones(usu, "ACT", act, myconn, tran) Then tab1.TabPages.Remove(aact) Else modulo = "ACT"
        'If Valida_OPciones(usu, "ACT", act) Then modulo = "ACT"
        actmenu(fac)
        If Not Valida_OPciones(usu, "FAC", fac, myconn, tran) Then tab1.TabPages.Remove(afac) Else modulo = "FAC"
        'If Valida_OPciones(usu, "FAC", fac) Then modulo = "FAC"
        actmenu(ani)
        If Not Valida_OPciones(usu, "ANI", ani, myconn, tran) Then tab1.TabPages.Remove(aani) Else modulo = "ANI"
        'If Valida_OPciones(usu, "ANI", ani) Then modulo = "ANI"
        actmenu(ban)
        If Not Valida_OPciones(usu, "BAN", ban, myconn, tran) Then tab1.TabPages.Remove(aban) Else modulo = "BAN"
        'If Valida_OPciones(usu, "BAN", ban) Then modulo = "BAN"
        fintran(tran)
        tran = Nothing
        myconn.close()
        myconn = Nothing

        Carga_Menu = True : Pentra.Visible = False : Pentra.Value = 0
        Exit Function
99:
        Pentra.Visible = False : Pentra.Value = 0
        MsgBox("Usted no tiene permiso para accesar el sistema, verifique con el administrador del mismo", MsgBoxStyle.Critical, "Datasoft") : Err.Clear()

    End Function


    Private Function Valida_OPciones(ByVal codusu, ByVal codmod, ByVal men, ByVal myconn, ByVal tran) As Boolean
        Valida_OPciones = False
        Dim DS As New DataSet

        ''cxc.MenuItems.Item(2).MenuItems.Item(8).MenuItems.Item(0).MenuItems.Item(0).MenuItems.Item(0).Enabled = False
        'cxc.MenuItems.Item(2).Enabled = True
        'cxc.MenuItems.Item(2).MenuItems.Item(8).Enabled = True
        'cxc.MenuItems.Item(2).MenuItems.Item(8).MenuItems.Item(0).Enabled = True
        'cxc.MenuItems.Item(2).MenuItems.Item(8).MenuItems.Item(0).MenuItems.Item(0).Enabled = True
        'cxc.MenuItems.Item(2).MenuItems.Item(8).MenuItems.Item(0).MenuItems.Item(0).MenuItems.Item(0).Visible = False

        ' utilizar los adaptadores para llenar el dataset con las tabla

        Call creadbtt("adm_opciones", "select adm_grupos_detalle.* from adm_usuarios inner join adm_grupos on adm_usuarios.gru_codigo = adm_grupos.gru_codigo  inner join adm_grupos_detalle on adm_grupos.gru_codigo = adm_grupos_detalle.gru_codigo where adm_usuarios.usu_codigo = '" & Trim(codusu) & "' and adm_grupos_detalle.opc_nivel = 0  and adm_grupos_detalle.mod_codigo = '" & Trim(codmod) & "'", DS, myconn, tran)
        Call creadbtt("adm_opciones1", "select adm_grupos_detalle.* from adm_usuarios inner join adm_grupos on adm_usuarios.gru_codigo = adm_grupos.gru_codigo  inner join adm_grupos_detalle on adm_grupos.gru_codigo = adm_grupos_detalle.gru_codigo where adm_usuarios.usu_codigo = '" & Trim(codusu) & "' and adm_grupos_detalle.opc_nivel = 1 and adm_grupos_detalle.mod_codigo = '" & Trim(codmod) & "'", DS, myconn, tran)
        Call creadbtt("adm_opciones2", "select adm_grupos_detalle.* from adm_usuarios inner join adm_grupos on adm_usuarios.gru_codigo = adm_grupos.gru_codigo  inner join adm_grupos_detalle on adm_grupos.gru_codigo = adm_grupos_detalle.gru_codigo where adm_usuarios.usu_codigo = '" & Trim(codusu) & "' and adm_grupos_detalle.opc_nivel = 2 and adm_grupos_detalle.mod_codigo = '" & Trim(codmod) & "'", DS, myconn, tran)
        Call creadbtt("adm_opciones3", "select adm_grupos_detalle.* from adm_usuarios inner join adm_grupos on adm_usuarios.gru_codigo = adm_grupos.gru_codigo  inner join adm_grupos_detalle on adm_grupos.gru_codigo = adm_grupos_detalle.gru_codigo where adm_usuarios.usu_codigo = '" & Trim(codusu) & "' and adm_grupos_detalle.opc_nivel = 3 and adm_grupos_detalle.mod_codigo = '" & Trim(codmod) & "'", DS, myconn, tran)
        Call creadbtt("adm_opciones4", "select adm_grupos_detalle.* from adm_usuarios inner join adm_grupos on adm_usuarios.gru_codigo = adm_grupos.gru_codigo  inner join adm_grupos_detalle on adm_grupos.gru_codigo = adm_grupos_detalle.gru_codigo where adm_usuarios.usu_codigo = '" & Trim(codusu) & "' and adm_grupos_detalle.opc_nivel = 4 and adm_grupos_detalle.mod_codigo = '" & Trim(codmod) & "'", DS, myconn, tran)
        Call creadbtt("adm_opciones5", "select adm_grupos_detalle.* from adm_usuarios inner join adm_grupos on adm_usuarios.gru_codigo = adm_grupos.gru_codigo  inner join adm_grupos_detalle on adm_grupos.gru_codigo = adm_grupos_detalle.gru_codigo where adm_usuarios.usu_codigo = '" & Trim(codusu) & "' and adm_grupos_detalle.opc_nivel = 5 and adm_grupos_detalle.mod_codigo = '" & Trim(codmod) & "'", DS, myconn, tran)

        Call creadbtt("adm_modulos", "select * from adm_modulos where mod_instalado = 'S' and mod_codigo  =  '" & Trim(codmod) & "' order by mod_codigo", DS, myconn, tran)

        ' defino variables del tipo DataTable
        Dim oTablaOpciones As DataTable
        Dim oTablaOpciones1 As DataTable
        Dim oTablaOpciones2 As DataTable
        Dim oTablaOpciones3 As DataTable
        Dim oTablaOpciones4 As DataTable
        Dim oTablaOpciones5 As DataTable
        Dim oTablaModulos As DataTable
        Dim oVista As DataView, oVista1 As DataView, oVista2 As DataView, oVista3 As DataView, oVista4 As DataView, oVista5 As DataView

        ' asigno a las variables los datos de las tablas del DataSet
        oTablaOpciones = DS.Tables("adm_opciones")
        oTablaOpciones1 = DS.Tables("adm_opciones1")
        oTablaOpciones2 = DS.Tables("adm_opciones2")
        oTablaOpciones3 = DS.Tables("adm_opciones3")
        oTablaOpciones4 = DS.Tables("adm_opciones4")
        oTablaOpciones5 = DS.Tables("adm_opciones5")
        oTablaModulos = DS.Tables("adm_modulos")

        ' lleno la vista con el contenido de la Tabla Territories
        oVista = oTablaOpciones.DefaultView
        oVista1 = oTablaOpciones1.DefaultView
        oVista2 = oTablaOpciones2.DefaultView
        oVista3 = oTablaOpciones3.DefaultView
        oVista4 = oTablaOpciones4.DefaultView
        oVista5 = oTablaOpciones5.DefaultView


        ' defino variable del tipo DataRow
        Dim Registro As DataRow


        For Each Registro In oTablaModulos.Rows
            ' si no hay un nodo raiz, se usar�a la siguiente l�nea

            ' realizo un filtro dentro de la vista
            oVista.RowFilter = "mod_codigo = '" & Registro("mod_codigo") & "'"

            ' ciclo para recorrer la vista previamente filtrada
            Dim a As Integer
            Dim a1 As Integer
            Dim a2 As Integer
            Dim a3 As Integer
            Dim a4 As Integer
            Dim a5 As Integer
            For a = 0 To oVista.Count - 1
                ' agrego el nodo en el tercer nivel
                If Trim("" & oVista.Item(a).Row("opc_enabled")) = "S" Then men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).Enabled = True : Valida_OPciones = True Else men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).Enabled = False
                'If Trim("" & oVista.Item(a).Row("opc_enabled")) = True Then Valida_OPciones = True
                ' realizo un filtro dentro de la vista
                oVista1.RowFilter = "opc_padre = '" & Trim("" & oVista.Item(a).Row("opc_codigo")) & "' and  mod_codigo = '" & Registro("mod_codigo") & "'"

                For a1 = 0 To oVista1.Count - 1

                    ' agrego el nodo en el cuarto nivel
                    If Trim("" & oVista1.Item(a1).Row("opc_enabled")) = "S" Then men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista1.Item(a1).Row("opc_codigo"))).Enabled = True : Valida_OPciones = True Else men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista1.Item(a1).Row("opc_codigo"))).Enabled = False
                    'If Trim("" & oVista1.Item(a1).Row("opc_enabled")) = True Then Valida_OPciones = True
                    ' realizo un filtro dentro de la vista
                    oVista2.RowFilter = "opc_padre = '" & Trim("" & oVista.Item(a).Row("opc_codigo")) & Trim("" & oVista1.Item(a1).Row("opc_codigo")) & "'  and mod_codigo = '" & Registro("mod_codigo") & "'"

                    For a2 = 0 To oVista2.Count - 1

                        ' agrego el nodo en el quinto nivel
                        If Trim("" & oVista2.Item(a2).Row("opc_enabled")) = "S" Then men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista1.Item(a1).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista2.Item(a2).Row("opc_codigo"))).Enabled = True : Valida_OPciones = True Else men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista1.Item(a1).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista2.Item(a2).Row("opc_codigo"))).Enabled = False
                        'If Trim("" & oVista2.Item(a2).Row("opc_enabled")) = True Then Valida_OPciones = True
                        ' realizo un filtro dentro de la vista
                        oVista3.RowFilter = "opc_padre = '" & Trim("" & oVista.Item(a).Row("opc_codigo")) & Trim("" & oVista1.Item(a1).Row("opc_codigo")) & Trim("" & oVista2.Item(a2).Row("opc_codigo")) & "' and mod_codigo = '" & Registro("mod_codigo") & "'"

                        For a3 = 0 To oVista3.Count - 1

                            ' agrego el nodo en el sexto nivel
                            If Trim("" & oVista3.Item(a3).Row("opc_enabled")) = "S" Then men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista1.Item(a1).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista2.Item(a2).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista3.Item(a3).Row("opc_codigo"))).Enabled = True : Valida_OPciones = True Else men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista1.Item(a1).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista2.Item(a2).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista3.Item(a3).Row("opc_codigo"))).Enabled = False
                            'If Trim("" & oVista3.Item(a3).Row("opc_enabled")) = True Then Valida_OPciones = True
                            ' realizo un filtro dentro de la vista
                            oVista4.RowFilter = "opc_padre = '" & Trim("" & oVista.Item(a).Row("opc_codigo")) & Trim("" & oVista1.Item(a1).Row("opc_codigo")) & Trim("" & oVista2.Item(a2).Row("opc_codigo")) & Trim("" & oVista3.Item(a3).Row("opc_codigo")) & "'  and mod_codigo = '" & Registro("mod_codigo") & "'"

                            For a4 = 0 To oVista4.Count - 1

                                ' agrego el nodo en el septimo nivel
                                If Trim("" & oVista4.Item(a4).Row("opc_enabled")) = "S" Then men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista1.Item(a1).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista2.Item(a2).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista3.Item(a3).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista4.Item(a4).Row("opc_codigo"))).Enabled = True : Valida_OPciones = True Else men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista1.Item(a1).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista2.Item(a2).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista3.Item(a3).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista4.Item(a4).Row("opc_codigo"))).Enabled = False
                                'If Trim("" & oVista4.Item(a4).Row("opc_enabled")) = True Then Valida_OPciones = True
                                ' realizo un filtro dentro de la vista
                                oVista5.RowFilter = "opc_padre = '" & Trim("" & oVista.Item(a).Row("opc_codigo")) & Trim("" & oVista1.Item(a1).Row("opc_codigo")) & Trim("" & oVista2.Item(a2).Row("opc_codigo")) & Trim("" & oVista3.Item(a3).Row("opc_codigo")) & Trim("" & oVista4.Item(a4).Row("opc_codigo")) & "'  and mod_codigo = '" & Registro("mod_codigo") & "'"

                                For a5 = 0 To oVista5.Count - 1

                                    ' agrego el nodo en el octavo nivel
                                    If Trim("" & oVista5.Item(a5).Row("opc_enabled")) = "S" Then men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista1.Item(a1).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista2.Item(a2).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista3.Item(a3).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista4.Item(a4).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista5.Item(a5).Row("opc_codigo"))).Enabled = True : Valida_OPciones = True Else men.MenuItems.Item(Val("" & oVista.Item(a).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista1.Item(a1).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista2.Item(a2).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista3.Item(a3).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista4.Item(a4).Row("opc_codigo"))).MenuItems.Item(Val("" & oVista5.Item(a5).Row("opc_codigo"))).Enabled = False
                                    'If Trim("" & oVista5.Item(a5).Row("opc_enabled")) = True Then Valida_OPciones = True

                                Next


                            Next



                        Next


                    Next
                Next
                ' expando todos los nodos de �rbol secundario
            Next
            ' expando todos los nodos de �rbol secundario

        Next
        ' modifico la propiedad Sorted a True para que los nodos est�n ordenados
        DS.Tables("adm_opciones").Clear()
        DS.Tables("adm_opciones1").Clear()
        DS.Tables("adm_opciones2").Clear()
        DS.Tables("adm_opciones3").Clear()
        DS.Tables("adm_opciones4").Clear()
        DS.Tables("adm_opciones5").Clear()
        DS.Tables("adm_modulos").Clear()
        oVista.Table.Clear()
        oVista1.Table.Clear()
        oVista2.Table.Clear()
        oVista3.Table.Clear()
        oVista4.Table.Clear()
        oVista5.Table.Clear()

        Exit Function
99:
        MsgBox("Error al validar los permisos de este usuario " & Err.Description, MsgBoxStyle.Critical, "DiroSoft") : Err.Clear()
    End Function


    Private Sub MenuItem336_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem336.Click
        Dim MiForm As New Registro_de_Host
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem337_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem337.Click
        Dim MiForm As New Registro_de_Modulos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem339_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem339.Click
        Dim MiForm As New Registro_de_Perfiles
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub MenuItem342_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem342.Click
        Dim MiForm As New Registro_de_Usuarios
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem341_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem341.Click
        Me.Close()
    End Sub

    Private Sub MenuItem343_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem343.Click
        Dim MiForm As New Registro_de_Empresas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem348_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem348.Click
        Dim MiForm As New Registro_de_pais
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem349_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem349.Click
        Dim MiForm As New Registro_de_Ciudades
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem350_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem350.Click
        Dim MiForm As New Registro_de_Municipios
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem351_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem351.Click
        Dim MiForm As New Registro_de_Sectores
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem352_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem352.Click
        Dim MiForm As New Registro_de_Nacionalidades
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub MenuItem344_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem344.Click
        Dim MiForm As New Registro_de_Ocupaciones
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    ''''

    Private Sub MenuItem345_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem345.Click
        Dim MiForm As New Registro_de_Niveles
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem346_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem346.Click
        Dim MiForm As New Regsitro_de_Estatus
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem347_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem347.Click
        Dim MiForm As New Registro_de_Sangre
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem356_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem356.Click
        Dim MiForm As New Registro_de_Titulo
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem357_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem357.Click
        Dim MiForm As New Registro_de_Afp
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem358_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem358.Click
        Dim MiForm As New Registro_De_Ars
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem353_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem353.Click
        Dim MiForm As New Registro_de_Departamentos_nom
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem359_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem359.Click
        Dim MiForm As New Registro_de_Empleados
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem355_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem355.Click
        Dim MiForm As New Registro_de_Tiponomina
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem360_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem360.Click
        Dim MiForm As New Registro_de_Grupos_emp
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem361_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem361.Click

    End Sub

    Private Sub MenuItem363_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem363.Click
        Dim MiForm As New Registro_de_Margenes
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem369_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem369.Click
        Dim MiForm As New Proceso_estados_financieros
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem245_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem245.Click
        Dim MiForm As New Preview_estados_financieros
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem367_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MiForm As New Registro_de_Etapas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem370_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem370.Click
        Dim MiForm As New Importar_Ponche
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem371_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem371.Click
        Dim MiForm As New Procesar_Ponches
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem372_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem372.Click
        Dim MiForm As New Procesar_Ponches
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem373_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MiForm As New Ordenes_de_Trabajos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem374_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MiForm As New Asignacion_Orden_Grupos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem375_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MiForm As New Cambio_estado_orden_Trabajo
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem376_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem376.Click
        Dim MiForm As New Parametros_de_Inventario
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem377_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem377.Click
        Dim MiForm As New Registro_de_Monedas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem379_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem379.Click
        rep_fil_gen_nom("Ocupaciones Registradas", "Reporte de Ocupaciones.rpt", "", True)
    End Sub

    Private Sub MenuItem380_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem380.Click
        rep_fil_gen_nom("Niveles Acad�micos Registrados", "Reporte de Niveles Academicos.rpt", "", True)
    End Sub

    Private Sub MenuItem381_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem381.Click
        rep_fil_gen_nom("Estados Registrados", "Reporte de Estados.rpt", "", True)
    End Sub

    Private Sub MenuItem382_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem382.Click
        rep_fil_gen_nom("Tipos de Sangres Registrados", "Reporte de Tipos  Sangres.rpt", "", True)
    End Sub

    Private Sub MenuItem383_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem383.Click
        rep_fil_gen_nom("T�tulos de Cortes�as Registrados", "Reporte de Titulos Cortesias.rpt", "", True)
    End Sub

    Private Sub MenuItem384_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem384.Click
        rep_fil_gen_nom("Empresas de AFP Registradas", "Reporte de  Empresas AFP.rpt", "", True)
    End Sub

    Private Sub MenuItem385_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem385.Click
        rep_fil_gen_nom("Empresas de ARS Registradas", "Reporte de Empresas ARS.rpt", "", True)
    End Sub

    Private Sub MenuItem386_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem386.Click
        rep_fil_gen_nom("Tipos de N�minas Registrados", "Reporte de Tipos  Nomina.rpt", "", False)
    End Sub

    Private Sub MenuItem387_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem387.Click
        rep_fil_gen_nom("Grupos Registrados", "Reporte de Grupos.rpt", "", True)
    End Sub

    Private Sub MenuItem388_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem388.Click
        rep_fil_gen_nom("Departamentos Registrados", "Reporte de Departamentos.rpt", "", True)
    End Sub

    Private Sub MenuItem389_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem389.Click
        rep_fil_gen_nom("Turnos Registrados", "Reporte de Turnos.rpt", "", True)
    End Sub

    Private Sub MenuItem391_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem391.Click
        rep_fil_gen_nom("Reloj Registrados", "Reporte de Reloj.rpt", "", True)
    End Sub

    Private Sub MenuItem392_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem392.Click
        rep_fil_gen_nom("D�as Feriados Registrados", "Reporte de Dias Feriados.rpt", "", True)
    End Sub

    Private Sub MenuItem393_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem393.Click
        Dim MiForm As New Registro_de_Lotes
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem394_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem394.Click
        Dim MiForm As New Proceso_de_Apertura_nomina
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem395_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MiForm As New Proceso_de_Prenomina
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem396_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem396.Click
        Dim MiForm As New Registro_de_Reloj
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub MenuItem400_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem400.Click
        Dim MiForm As New Registro_de_Turnos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem397_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem397.Click
        Dim MiForm As New Registro_dias_feriado
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem398_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem398.Click
        Dim MiForm As New Registro_Periodo_trabajo
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem399_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem399.Click
        Dim MiForm As New Registro_Tipo_Horas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem365_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem365.Click
        Dim MiForm As New Registro_Tipo_Descuentos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem401_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem401.Click
        Dim MiForm As New Registro_Tipo_Ingreso
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem366_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem366.Click
        Dim MiForm As New Registro_de_Descuentos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem402_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem402.Click
        Dim MiForm As New Registro_de_Ingresos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem404_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem404.Click
        Dim MiForm As New Registro_de_Concepto_Prestamos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem405_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem405.Click
        Dim MiForm As New Registro_de_Prestamos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub MenuItem407_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem407.Click
        Dim MiForm As New Proceso_Inventario_Fisico
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem410_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem410.Click
        Dim MiForm As New Preview_cuadre_lote
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem411_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MiForm As New Proceso_de_Distribucion
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem412_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem412.Click
        Dim MiForm As New Filtro_de_Prenomina
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem413_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem413.Click
        Dim MiForm As New Filtro_de_nomina
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem390_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem390.Click
        Dim MiForm As New Filtro_de_Empleado
        MiForm.Text = "Empleados Registrados"
        MiForm.opcional.Text = ""
        MiForm.rep.Text = "Reporte de Empleados.rpt"
        MiForm.Filtro.Text = ""
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem414_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem414.Click
        Dim MiForm As New ExistenciaxAlmacen
        MiForm.Text = "Reporte de Art�culos de Combos"
        MiForm.rep.Text = "Reporte de Articulos Combos.rpt"
        MiForm.tiprep = "COM"
        MiForm.Filtro.Text = "  {inv_articulos.emp_codigo} = " & emp_id() & " and {inv_articulos.art_combo} = 'S'  "
        MiForm.Ctipo.Enabled = False
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem416_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem416.Click
        Dim MiForm As New Filtros_de_Movimientos
        MiForm.Text = "Reporte de Transacciones"
        MiForm.rep.Text = "Reporte de Transacciones de Inventarios.rpt"
        MiForm.Filtro.Text = "  {inv_movimientos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem418_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem418.Click
        rep_fil_mov_fac("Reporte de Transacciones", "Reporte de Transacciones de Facturacion.rpt", "")
    End Sub

    Private Sub MenuItem504_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem504.Click
        Me.Close()
    End Sub



    Private Sub MenuItem426_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem426.Click
        Dim MiForm As New Registro_de_Marcas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem427_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem427.Click
        Dim MiForm As New Registro_de_Modelos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem429_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem429.Click
        Dim MiForm As New Registro_de_Unidades
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem434_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem434.Click
        Dim MiForm As New Registro_de_Origen
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem435_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem435.Click
        Dim MiForm As New Registro_de_Grupos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem437_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem437.Click
        Dim MiForm As New Registro_de_Clases
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem439_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem439.Click
        Dim MiForm As New Registro_de_articulos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem433_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem433.Click
        Dim MiForm As New Registro_de_Clientes
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem436_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem436.Click
        Dim MiForm As New Registro_de_Suplidores
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem438_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem438.Click
        Dim MiForm As New Inventario.Movimientos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem444_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem444.Click
        Dim MiForm As New Cuentas_por_Cobrar.Proceso_de_facturas_de_Servicios
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem445_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem445.Click
        Dim MiForm As New Cuentas_por_Cobrar.Proceso_Pagos_Facturas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem446_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem446.Click
        Dim MiForm As New Cuentas_por_Cobrar.Proceso_Nota_Facturas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem447_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem447.Click
        Dim MiForm As New Cuentas_por_Pagar.Proceso_de_facturas_cxp
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem448_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem448.Click
        Dim MiForm As New Cuentas_por_Pagar.Proceso_Pagos_Facturas_cxp
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem449_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem449.Click
        Dim MiForm As New Cuentas_por_Pagar.Proceso_Nota_Facturas_cxp
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem454_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem454.Click
        Dim MiForm As New Filtro_de_Articulos
        MiForm.Text = "Reporte de Articulos"
        MiForm.rep.Text = "Reporte de Articulos.rpt"

        MiForm.Filtro.Text = "  {inv_articulos.emp_codigo} = " & emp_id()

        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem460_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem460.Click
        rep_fil_cli("Reporte de Clientes", "Reporte de Clientes.rpt", 0, "")
    End Sub

    Private Sub MenuItem461_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem461.Click
        rep_fil_fac("Facturas Pendientes", "Reporte facturas pendientes.rpt", "{@balance} > 0")
    End Sub

    Private Sub MenuItem462_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem462.Click
        rep_fil_pag("Pagos detallados", "Reporte Pagos a Factura detallado.rpt", "{@total} > 0")
    End Sub

    Private Sub MenuItem463_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem463.Click
        rep_fil_not("Notas detalladas", "Reporte notas a Factura detallado.rpt", "")
    End Sub

    Private Sub MenuItem465_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem465.Click
        rep_fil_sup("Reporte de Suplidores", "Reporte de Suplidores.rpt", 0, "")
    End Sub

    Private Sub MenuItem466_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem466.Click
        rep_fil_fac_cxp("Facturas por Pagar", "Reporte facturas por pagar.rpt", "{@balance} > 0")
    End Sub

    Private Sub MenuItem467_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem467.Click
        rep_fil_pag_cxp("Pagos Detallados", "Reporte Pagos a Factura detallado cxp.rpt", "{@total} > 0")
    End Sub

    Private Sub MenuItem468_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem468.Click
        rep_fil_not_cxp("Notas detalladas", "Reporte de notas cxp detalladas.rpt", "")
    End Sub

    Private Sub MenuItem472_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem472.Click
        Dim MiForm As New Administrador_Sistema.Registro_Tipo_Comprobante
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub



    Private Sub MenuItem477_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem477.Click
        Dim MiForm As New Filtro_Existencia_Fecha
        MiForm.rep.Text = "Reporte Existencia a Fecha.rpt"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem478_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem478.Click
        Dim MiForm As New Filtros_de_Movimientos
        MiForm.Text = "Reporte de Movimientos"
        MiForm.rep.Text = "Reporte de Movimientos.rpt"
        MiForm.Filtro.Text = "  {inv_movimientos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem479_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem479.Click
        Dim MiForm As New Filtros_de_Movimientos
        MiForm.Text = "Reporte de Movimientos"
        MiForm.rep.Text = "Reporte de Movimientos Detallado.rpt"
        MiForm.Filtro.Text = "  {inv_movimientos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
    Public Shared Sub actmenu(ByVal men As MainMenu)
        Dim col, fil, fil2, fil3, fil4, fil5, can
        For col = 0 To (men.MenuItems.Count - 1)
            men.MenuItems.Item(col).Enabled = False
            For fil = 0 To (men.MenuItems.Item(col).MenuItems.Count - 1)
                men.MenuItems.Item(col).MenuItems.Item(fil).Enabled = False
                For fil2 = 0 To (men.MenuItems.Item(col).MenuItems.Item(fil).MenuItems.Count - 1)
                    men.MenuItems.Item(col).MenuItems.Item(fil).MenuItems(fil2).Enabled = False
                    For fil3 = 0 To (men.MenuItems.Item(col).MenuItems.Item(fil).MenuItems.Item(fil2).MenuItems.Count - 1)
                        men.MenuItems.Item(col).MenuItems.Item(fil).MenuItems(fil2).MenuItems(fil3).Enabled = False
                        For fil4 = 0 To (men.MenuItems.Item(col).MenuItems.Item(fil).MenuItems.Item(fil2).MenuItems.Item(fil3).MenuItems.Count - 1)
                            men.MenuItems.Item(col).MenuItems.Item(fil).MenuItems(fil2).MenuItems(fil3).MenuItems(fil4).Enabled = False
                            For fil5 = 0 To (men.MenuItems.Item(col).MenuItems.Item(fil).MenuItems.Item(fil2).MenuItems.Item(fil3).MenuItems.Item(fil4).MenuItems.Count - 1)
                                men.MenuItems.Item(col).MenuItems.Item(fil).MenuItems(fil2).MenuItems(fil3).MenuItems(fil4).MenuItems(fil5).Enabled = False
                            Next
                        Next
                    Next
                Next
            Next
        Next
    End Sub


    Private Sub MenuItem480_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem480.Click
        Dim MiForm As New Procesar_Nomina
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem482_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem482.Click
        Dim MiForm As New Administrador_Sistema.Visor_de_Sucesos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem484_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem484.Click

    End Sub

    Private Sub MenuItem485_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem486_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem486.Click
        Dim MiForm As New Facturacion.Registro_Tipo_Ruta
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem487_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem487.Click
        Dim MiForm As New Facturacion.Registro_de_Rutas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem485_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem485.Click
        Dim MiForm As New Facturacion.Registro_de_Conceptos
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem489_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem489.Click
        Dim MiForm As New Registro_de_Clientes_Movil
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem493_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem493.Click
        rep_fil_gen_Fac("Utensilios Registrados", "Reporte de utensilio.rpt", "")
    End Sub

    Private Sub MenuItem497_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem497.Click
        rep_fil_gen_Fac("Utensilios Registrados", "Reporte de Secciones.rpt", "")
    End Sub



    Private Sub MenuItem494_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem494.Click
        rep_fil_gen_Fac("Paneles Registrados", "Reporte de Paneles.rpt", "")
    End Sub

    Private Sub MenuItem495_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem495.Click
        rep_fil_gen_Fac("Usos de Secciones Registrados", "Reporte de Usos.rpt", "")
    End Sub

    Private Sub MenuItem505_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem505.Click
        Dim MiForm As New Proceso_Orden_Compra
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub


    Private Sub MenuItem508_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem508.Click
        rep_fil_gen_Fac("Reporte de Precios por Secciones", "Reporte de PreciosxSecciones.rpt", "")
    End Sub

    Private Sub MenuItem511_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem511.Click
        rep_fil_cli("Reporte de Clientes x Rutas", "Reporte de Clientes x Rutas.rpt", 0, "")
    End Sub

    Private Sub MenuItem516_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem516.Click
        Dim MiForm As New Facturacion.Registro_de_Contactos_Ocasiones
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem513_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem513.Click
        Dim MiForm As New Facturacion.Registro_Tipos_de_Ocasiones
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem514_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem514.Click
        Dim MiForm As New Facturacion.Registro_de_relaciones
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem518_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem518.Click
        Dim MiForm As New Facturacion.Preview_fechas_ocasiones
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem524_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem524.Click
        rep_fil_gen_Fac("Tipos de relaciones entre contactos", "Reporte de tipo de relaciones.rpt", "")
    End Sub

    Private Sub MenuItem523_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem523.Click
        rep_fil_gen_Fac("Tipos de ocasiones", "Reporte de tipo de ocasion.rpt", "")
    End Sub

    Private Sub MenuItem521_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem521.Click
        Dim frm As New Facturacion.Filtro_de_relaciones_por_Contactos
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MenuItem520_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem520.Click
        Dim frm As New Facturacion.Filtro_de_ocasiones_contactos
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MenuItem526_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem526.Click
        Dim frm As New Bancos.Proceso_Solicitud_cheque
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MenuItem527_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem527.Click
        Dim frm As New Inventario.Proceso_Cuadre_Inventario
        frm.Show()
        frm = Nothing
    End Sub

    Private Sub MenuItem529_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem529.Click
        Dim MiForm As New Filtro_desembolsos
        MiForm.MdiParent = Me
        MiForm.Show()
    End Sub

    Private Sub MenuItem531_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem531.Click
        Dim MiForm As New Inventario.Filtro_de_Ventas
        MiForm.Text = "Reporte de Ventas"
        MiForm.rep.Text = "Reporte de ventas inventario.rpt"
        MiForm.Filtro.Text = "  {fac_ventas.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem533_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem533.Click
        Dim MiForm As New Filtro_Entrada_Descuadrada
        MiForm.Text = "Reporte de Entradas Decuadrada"
        MiForm.rep.Text = "Reporte de diario cnt.rpt"
        MiForm.Filtro.Text = "{con_movimientos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem534_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem534.Click
        Dim MiForm As New Parametros_de_CxP
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem537_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem537.Click
        Dim MiForm As New Inventario.Filtro_de_Ventas
        MiForm.Text = "Reporte de Ventas"
        MiForm.rep.Text = "Reporte de ventas inventario total.rpt"
        MiForm.Filtro.Text = "  {fac_ventas.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem539_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem539.Click
        Dim MiForm As New Inventario.Filtro_de_Ventas
        MiForm.Text = "Reporte de Ventas"
        MiForm.rep.Text = "Reporte de ventas inventario diario.rpt"
        MiForm.Filtro.Text = "  {fac_ventas.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem541_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem541.Click
        rep_fil_fac_cxp("Facturas de Otras Retenciones por Suplidor", "Reporte facturas con otras retenciones.rpt", " {cxp_facturas.cxp_otras_retenciones} > 0 ")
    End Sub

    Private Sub MenuItem543_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem543.Click
        Dim MiForm As New Filtro_de_Relacion
        MiForm.Text = "Reporte Relacion de Movimientos de Banco"
        MiForm.rep.Text = "Reporte de Relacion de Movimientos.rpt"
        MiForm.b10.Enabled = False
        MiForm.Filtro.Text = "{ban_movimientos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
        'rep_fil_doc_banco("Reporte Relacion de Movimientos de Banco", "Reporte de Relacion de Movimientos.rpt", 0, "")
    End Sub

    Private Sub MenuItem544_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem544.Click
        rep_fil_mov_fac("Movimientos de Caja", "Reporte de movimientos fac.rpt", "")
    End Sub

    Private Sub MenuItem546_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem546.Click

    End Sub

    Private Sub MenuItem547_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem547.Click
        rep_fil_mov_fac_com("Comisiones por Cobros", "Reporte de comisiones detalladas cobros.rpt", "")
    End Sub

    Private Sub MenuItem550_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem550.Click
        Dim MiForm As New Filtro_antiguedad
        MiForm.tipo.Text = "T"
        MiForm.tip.Text = "F"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem551_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem551.Click
        Dim MiForm As New Filtro_antiguedad_cxp
        MiForm.tipo.Text = "T"
        MiForm.tip.Text = "T"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem554_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem554.Click
        Dim MiForm As New Inventario.Filtro_de_Ventas
        MiForm.Text = "Reporte de Comisiones Detallado"
        MiForm.rep.Text = "Reporte de comisiones detalladas.rpt"
        MiForm.Filtro.Text = "  {fac_ventas.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem555_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem555.Click
        Dim MiForm As New Inventario.Filtro_de_Ventas
        MiForm.Text = "Reporte de Comisiones Totalizadas"
        MiForm.rep.Text = "Reporte de comisiones totalizada.rpt"
        MiForm.Filtro.Text = "  {fac_ventas.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem557_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem557.Click
        Dim MiForm As New Inventario.Registro_de_estandar_comision
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem549_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem549.Click
        rep_fil_mov_fac_com("Comisiones por Cobros", "Reporte de comisiones totalizadas cobros.rpt", "")
    End Sub

    Private Sub MenuItem559_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem559.Click
        Dim MiForm As New Inventario.Registro_de_Ofertas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem560_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem560.Click
        Dim MiForm As New Facturacion.Proceso_Ventas_Moviles
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem563_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem563.Click
        rep_fil_vis("Reporte de visitas detalladas", "Reporte de visitas detalladas.rpt", 0, "")
    End Sub

    Private Sub MenuItem564_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem564.Click
        rep_fil_vis("Reporte de visitas totalizadas", "Reporte de visitas totalizadas.rpt", 0, "")
    End Sub

    Private Sub MenuItem566_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem566.Click
        Dim MiForm As New Inventario.Arqueo
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem568_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem568.Click
        Dim MiForm As New Facturacion.Generar_Archivo_Ventas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem569_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem569.Click
        Dim MiForm As New Facturacion.Registro_Orden_Ruta
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem570_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem570.Click
        Dim MiForm As New Nomina.Registro_de_Horas
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem367_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem367.Click
        Dim MiForm As New Nomina.Proceso_Cerrar_Nomina
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem132_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem132.Click

    End Sub

    Private Sub MenuItem375_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem375.Click
        Dim MiForm As New Nomina.Filtro_de_Pagos_Prestamos
        MiForm.Text = "Reporte de Pr�stamos"
        MiForm.rep.Text = "Reporte de Pagos Prestamos por Nomina.rpt"
        MiForm.Filtro.Text = "  {nom_prestamos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem374_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem374.Click
        Dim MiForm As New Nomina.Filtro_de_Prestamos
        MiForm.Text = "Reporte de Pr�stamos"
        MiForm.rep.Text = "Reporte de Prestamos.rpt"
        MiForm.Filtro.Text = "  {nom_prestamos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem395_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem395.Click
        Dim MiForm As New Nomina.Filtro_de_Pagos_Prestamos
        MiForm.Text = "Reporte Historial de Pr�stamos"
        MiForm.rep.Text = "Reporte de Pagos Prestamos por Nomina2.rpt"
        MiForm.Filtro.Text = "  {nom_prestamos.emp_codigo} = " & emp_id()
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem411_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem411.Click
        Dim MiForm As New Nomina.Cambio_de_Salario
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem571_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem571.Click
        Dim MiForm As New Nomina.Consulta_Cambio_de_Salario
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem573_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem573.Click
        Dim MiForm As New Cuentas_por_Cobrar.Generacion_seriales
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem575_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem575.Click
        Dim MiForm As New Inventario.Filtro_de_Ventas_Por_Productos
        MiForm.Text = "Reporte de Ventas por Productos"
        MiForm.rep.Text = "Reporte Ventas por Productos.rpt"
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub

    Private Sub MenuItem577_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem577.Click
        Dim MiForm As New RelacionUsuario_Empresa
        MiForm.MdiParent = Me
        MiForm.Show()
        MiForm = Nothing
    End Sub
End Class