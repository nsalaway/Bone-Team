//Maya ASCII 2016 scene
//Name: Bedding.ma
//Last modified: Tue, Apr 26, 2016 11:26:16 AM
//Codeset: 1252
requires maya "2016";
currentUnit -l centimeter -a degree -t film;
fileInfo "application" "maya";
fileInfo "product" "Maya 2016";
fileInfo "version" "2016";
fileInfo "cutIdentifier" "201502261600-953408";
fileInfo "osv" "Microsoft Windows 8 Home Premium Edition, 64-bit  (Build 9200)\n";
fileInfo "license" "student";
createNode transform -s -n "persp";
	rename -uid "5E46C475-4C2A-4C5C-46F0-EFB7E7F5ADD6";
	setAttr ".v" no;
	setAttr ".t" -type "double3" -3.3789474031294278 11.293952291934326 1.303450070642757 ;
	setAttr ".r" -type "double3" -78.938352729999465 85.79999999993548 -8.6855078528817753e-014 ;
createNode camera -s -n "perspShape" -p "persp";
	rename -uid "042BA5AD-4E04-8B10-1E92-27BF459F8C99";
	setAttr -k off ".v" no;
	setAttr ".fl" 34.999999999999993;
	setAttr ".coi" 11.455500951756543;
	setAttr ".imn" -type "string" "persp";
	setAttr ".den" -type "string" "persp_depth";
	setAttr ".man" -type "string" "persp_mask";
	setAttr ".hc" -type "string" "viewSet -p %camera";
createNode transform -s -n "top";
	rename -uid "C1BDB383-4502-F5BC-DA09-E89F59C418DC";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 100.1 0 ;
	setAttr ".r" -type "double3" -89.999999999999986 0 0 ;
createNode camera -s -n "topShape" -p "top";
	rename -uid "9538E720-420C-3000-A4BE-2889DE6864C2";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 100.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "top";
	setAttr ".den" -type "string" "top_depth";
	setAttr ".man" -type "string" "top_mask";
	setAttr ".hc" -type "string" "viewSet -t %camera";
	setAttr ".o" yes;
createNode transform -s -n "front";
	rename -uid "5538B2C2-4065-1FCD-693C-2AA444C4565C";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 0 0 100.1 ;
createNode camera -s -n "frontShape" -p "front";
	rename -uid "8A8446F6-4415-1ED0-825E-6CB16862BAF2";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 100.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "front";
	setAttr ".den" -type "string" "front_depth";
	setAttr ".man" -type "string" "front_mask";
	setAttr ".hc" -type "string" "viewSet -f %camera";
	setAttr ".o" yes;
createNode transform -s -n "side";
	rename -uid "2DB06971-4005-22D7-D798-75B063AC9244";
	setAttr ".v" no;
	setAttr ".t" -type "double3" 100.1 0 0 ;
	setAttr ".r" -type "double3" 0 89.999999999999986 0 ;
createNode camera -s -n "sideShape" -p "side";
	rename -uid "0A9883CC-478F-B2B1-C947-E58ADFCD4A07";
	setAttr -k off ".v" no;
	setAttr ".rnd" no;
	setAttr ".coi" 100.1;
	setAttr ".ow" 30;
	setAttr ".imn" -type "string" "side";
	setAttr ".den" -type "string" "side_depth";
	setAttr ".man" -type "string" "side_mask";
	setAttr ".hc" -type "string" "viewSet -s %camera";
	setAttr ".o" yes;
createNode transform -n "pCube1";
	rename -uid "4D9CB329-4CB8-9A29-7F71-1BA2C1E1F53C";
	setAttr ".t" -type "double3" -3.3809933458055479 0.77737920966021323 0.7434376917361929 ;
createNode mesh -n "pCubeShape1" -p "pCube1";
	rename -uid "B5B6FB6C-4AEA-3F90-596A-76B122645912";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr ".bck" 3;
createNode transform -n "pCube2";
	rename -uid "EF485323-4A6C-4BB4-F5D0-5680215F89A9";
	setAttr ".t" -type "double3" -7.4776623513058427 1.0168090164628609 -6.1964304803929657 ;
	setAttr ".s" -type "double3" 0.2281572383030295 1.5775435841333871 0.32396807164119795 ;
createNode mesh -n "pCubeShape2" -p "pCube2";
	rename -uid "761620E8-41A7-784F-0643-95AE9F280FB4";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -6.66200161 -0.77737921 4.72731066 6.66200161 -0.77737921 4.72731066
		 -6.66200161 0.77737921 4.72731066 6.66200161 0.77737921 4.72731066 -6.66200161 0.77737921 -4.72731066
		 6.66200161 0.77737921 -4.72731066 -6.66200161 -0.77737921 -4.72731066 6.66200161 -0.77737921 -4.72731066;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".bck" 3;
createNode transform -n "pCube3";
	rename -uid "D74B72D6-4605-9DFD-D0F1-1E8EA66B8F56";
	setAttr ".t" -type "double3" -7.4776623513058427 1.0168090164628609 7.8410879730765881 ;
	setAttr ".s" -type "double3" 0.2281572383030295 1.5775435841333871 0.32396807164119795 ;
createNode mesh -n "pCubeShape3" -p "pCube3";
	rename -uid "D4DCAF29-459C-700B-F3F1-14A1EC5E814A";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -6.66200161 -0.77737921 4.72731066 6.66200161 -0.77737921 4.72731066
		 -6.66200161 0.77737921 4.72731066 6.66200161 0.77737921 4.72731066 -6.66200161 0.77737921 -4.72731066
		 6.66200161 0.77737921 -4.72731066 -6.66200161 -0.77737921 -4.72731066 6.66200161 -0.77737921 -4.72731066;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".bck" 3;
createNode transform -n "pCube4";
	rename -uid "AC0880F8-45F8-7903-4E79-5E96DBD3A94F";
	setAttr ".t" -type "double3" -7.4776623513058427 0.64872574402190275 2.2867281580787848 ;
	setAttr ".s" -type "double3" 0.21282340605646688 1.5775435841333871 0.49106749762964474 ;
createNode mesh -n "pCubeShape4" -p "pCube4";
	rename -uid "4D2423D5-4C59-1C29-351C-AB814EC209B7";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.28125 0.34375 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".clst[0].clsn" -type "string" "SculptFreezeColorTemp";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 31 ".pt";
	setAttr ".pt[2]" -type "float3" 0 -0.063160256 0 ;
	setAttr ".pt[3]" -type "float3" -0.47359139 -0.0853021 7.4505806e-009 ;
	setAttr ".pt[4]" -type "float3" 0.17864436 1.3038516e-008 0.084207691 ;
	setAttr ".pt[5]" -type "float3" -0.17864436 -0.085302092 0.084207691 ;
	setAttr ".pt[14]" -type "float3" 0 -0.0853021 0 ;
	setAttr ".pt[16]" -type "float3" -0.32482052 -0.063160256 0 ;
	setAttr ".pt[18]" -type "float3" -0.17864436 1.3038516e-008 0.084207691 ;
	setAttr ".pt[20]" -type "float3" 0.17864436 1.3038516e-008 0.084207691 ;
	setAttr ".pt[32]" -type "float3" -0.58483273 -0.063160256 0 ;
	setAttr ".pt[37]" -type "float3" 0.17864436 1.3038516e-008 0.084207691 ;
	setAttr ".pt[41]" -type "float3" 0.15441403 0 0 ;
	setAttr ".pt[42]" -type "float3" 0.30882806 0 0 ;
	setAttr ".pt[44]" -type "float3" 3.2938396e-016 0 0 ;
	setAttr ".pt[51]" -type "float3" 0.29678133 0 0 ;
	setAttr ".pt[54]" -type "float3" 0.28588921 0 0 ;
	setAttr ".pt[59]" -type "float3" -0.47359139 0 7.4505806e-009 ;
	setAttr ".pt[65]" -type "float3" 0 -0.0853021 0 ;
	setAttr ".pt[67]" -type "float3" -0.14413223 0 0 ;
	setAttr ".pt[68]" -type "float3" -0.28588921 -0.0853021 0 ;
	setAttr ".pt[70]" -type "float3" 3.2938396e-016 0 0 ;
	setAttr ".pt[71]" -type "float3" 0.14413223 0 0 ;
	setAttr ".pt[72]" -type "float3" 0.029981337 -0.063160256 0 ;
	setAttr ".pt[74]" -type "float3" -0.17864436 1.3038516e-008 0.084207691 ;
	setAttr ".pt[81]" -type "float3" -0.15441403 0 0 ;
	setAttr ".pt[82]" -type "float3" -0.30882806 0 0 ;
	setAttr ".pt[88]" -type "float3" -0.2967813 0 0 ;
	setAttr ".pt[89]" -type "float3" -0.28588921 0 0 ;
	setAttr ".pt[90]" -type "float3" -0.2858893 0 0 ;
	setAttr ".pt[95]" -type "float3" -0.58483273 0 0 ;
	setAttr ".pt[96]" -type "float3" -0.32482052 0 0 ;
	setAttr ".pt[97]" -type "float3" 0.029981486 0 0 ;
	setAttr ".bck" 3;
createNode mesh -n "polySurfaceShape1" -p "pCube4";
	rename -uid "77747E28-40AA-A86A-4096-BCA07A126D52";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -6.66200161 -0.77737921 4.72731066 6.66200161 -0.77737921 4.72731066
		 -6.66200161 0.77737921 4.72731066 6.66200161 0.77737921 4.72731066 -6.66200161 0.77737921 -4.72731066
		 6.66200161 0.77737921 -4.72731066 -6.66200161 -0.77737921 -4.72731066 6.66200161 -0.77737921 -4.72731066;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".bck" 3;
createNode transform -n "pCube5";
	rename -uid "5295509E-47D6-3F0F-EB0D-4FA30DFAD1C9";
	setAttr ".t" -type "double3" -7.6355649012696487 0.83371339809959166 -0.76862116745135511 ;
	setAttr ".r" -type "double3" 8.7206640348806825 -185.03577318441208 -0.47418519108951118 ;
	setAttr ".s" -type "double3" 0.21282340605646688 1.5775435841333871 0.49106749762964474 ;
createNode mesh -n "pCubeShape5" -p "pCube5";
	rename -uid "F87FB7C9-4C8F-EBFF-903E-3895E15388E6";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 146 ".uvst[0].uvsp[0:145]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25 0.50000006 0.125 0.5 0 0.5 1 0.625 0.125 0.5 0.25 0.375
		 0.125 0.5 0.375 0.625 0.375 0.75 0.25 0.5 0.5 0.25 0.25 0.375 0.375 0.50000006 0.62499994
		 0.625 0.625 0.875 0.125 0.5 0.75 0.125 0.125 0.375 0.625 0.5 0.875 0.625 0.875 0.75
		 0 0.5 1 0.25 0 0.375 0.875 0.75000006 0.125 0.75 0 0.875 0.125 0.75 0.25 0.25000003
		 0.125 0.25 0 0.25 0.25 0.125 0.125 0.43750003 0.0625 0.375 0.0625 0.4375 0 0.4375
		 1 0.5 0.0625 0.43750003 0.125 0.43720743 0.3096748 0.3125 0.25 0.375 0.3125 0.4375
		 0.25 0.5 0.3125 0.4375 0.375 0.43781355 0.56249821 0.125 0.1875 0.375 0.5625 0.4375
		 0.5 0.5 0.5625 0.43750003 0.625 0.4375 0.81249994 0.1875 0 0.375 0.8125 0.4375 0.75
		 0.5 0.8125 0.4375 0.875 0.6900937 0.063052505 0.625 0.0625 0.625 0.9375 0.6875 0
		 0.75 0.0625 0.6875 0.125 0.19009371 0.063052505 0.125 0.0625 0.375 0.6875 0.1875
		 0 0.25 0.0625 0.18750001 0.125 0.56249994 0.0625 0.5625 0 0.5625 1 0.5625 0.125 0.56218648
		 0.18750177 0.625 0.1875 0.5625 0.25 0.5 0.1875 0.43781355 0.18750177 0.375 0.1875
		 0.5627926 0.3096748 0.625 0.3125 0.6875 0.25 0.5625 0.375 0.5627926 0.4403252 0.625
		 0.4375 0.8125 0.25 0.5625 0.5 0.5 0.4375 0.43720743 0.4403252 0.1875 0.25 0.375 0.4375
		 0.56218642 0.56249827 0.625 0.5625 0.875 0.1875 0.5625 0.625 0.56250006 0.68750006
		 0.625 0.6875 0.875 0.0625 0.5625 0.75 0.5 0.6875 0.43750003 0.68750006 0.375 0.6875
		 0.5625 0.8125 0.625 0.8125 0.8125 0 0.5625 0.875 0.5625 0.9375 0.625 0.9375 0.5625
		 1 0.5 0.9375 0.4375 0.9375 0.4375 1 0.3125 0 0.375 0.9375 0.8099063 0.063052505 0.8125
		 0 0.875 0.0625 0.8125 0.125 0.8125 0.1875 0.875 0.1875 0.8125 0.25 0.75 0.1875 0.68750006
		 0.18750003 0.6875 0.25 0.3099063 0.063052505 0.3125 0 0.3125 0.125 0.31249997 0.1875
		 0.3125 0.25 0.25 0.1875 0.18750003 0.18750003 0.1875 0.25 0.125 0.1875;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".clst[0].clsn" -type "string" "SculptFreezeColorTemp";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 31 ".pt";
	setAttr ".pt[3]" -type "float3" -0.47359139 0 7.4505806e-009 ;
	setAttr ".pt[4]" -type "float3" 0.16913223 -0.15383704 0.16038057 ;
	setAttr ".pt[5]" -type "float3" -0.18815649 -0.15383704 0.16038057 ;
	setAttr ".pt[15]" -type "float3" -0.0095121143 -0.15383705 0.076172873 ;
	setAttr ".pt[16]" -type "float3" -0.32482052 0 0 ;
	setAttr ".pt[18]" -type "float3" -0.17864436 1.3038516e-008 0.084207691 ;
	setAttr ".pt[20]" -type "float3" 0.17864436 1.3038516e-008 0.084207691 ;
	setAttr ".pt[32]" -type "float3" -0.58483273 0 0 ;
	setAttr ".pt[37]" -type "float3" 0.17864436 1.3038516e-008 0.084207691 ;
	setAttr ".pt[38]" -type "float3" -0.0095121143 -0.15383705 0.076172873 ;
	setAttr ".pt[41]" -type "float3" 0.15441403 0 0 ;
	setAttr ".pt[42]" -type "float3" 0.30882806 0 0 ;
	setAttr ".pt[44]" -type "float3" 3.2938396e-016 0 0 ;
	setAttr ".pt[51]" -type "float3" 0.29678133 0 0 ;
	setAttr ".pt[54]" -type "float3" 0.28588921 0 0 ;
	setAttr ".pt[59]" -type "float3" -0.47359139 0 7.4505806e-009 ;
	setAttr ".pt[67]" -type "float3" -0.14413223 0 0 ;
	setAttr ".pt[68]" -type "float3" -0.28588921 0 0 ;
	setAttr ".pt[69]" -type "float3" -0.0095121143 -0.15383705 0.076172873 ;
	setAttr ".pt[70]" -type "float3" 3.2938396e-016 0 0 ;
	setAttr ".pt[71]" -type "float3" 0.14413223 0 0 ;
	setAttr ".pt[72]" -type "float3" 0.029981337 0 0 ;
	setAttr ".pt[74]" -type "float3" -0.17864436 1.3038516e-008 0.084207691 ;
	setAttr ".pt[81]" -type "float3" -0.15441403 0 0 ;
	setAttr ".pt[82]" -type "float3" -0.30882806 0 0 ;
	setAttr ".pt[88]" -type "float3" -0.2967813 0 0 ;
	setAttr ".pt[89]" -type "float3" -0.28588921 0 0 ;
	setAttr ".pt[90]" -type "float3" -0.2858893 0 0 ;
	setAttr ".pt[95]" -type "float3" -0.58483273 0 0 ;
	setAttr ".pt[96]" -type "float3" -0.32482052 0 0 ;
	setAttr ".pt[97]" -type "float3" 0.029981486 0 0 ;
	setAttr -s 98 ".vt[0:97]"  -6.66200161 -0.77737921 4.72731066 6.66200161 -0.77737921 4.72731066
		 -6.66200161 0.77737921 4.72731066 6.66200161 0.77737921 4.72731066 -6.66200161 0.77737921 -4.72731066
		 6.66200161 0.77737921 -4.72731066 -6.66200161 -0.77737921 -4.72731066 6.66200161 -0.77737921 -4.72731066
		 0 0 4.72731066 0 -0.77737921 4.72731066 6.66200161 0 4.72731066 0 0.85239661 4.72731066
		 -6.66200161 0 4.72731066 0 0.85239661 0 5.67233181 0.77737921 0 0 0.85239661 -4.72731066
		 -5.67233181 0.77737921 0 0 0 -4.72731066 6.66200161 0 -4.72731066 0 -0.77737921 -4.72731066
		 -6.66200161 0 -4.72731066 0 -0.77737921 0 6.66200161 -0.77737921 0 -6.66200161 -0.77737921 0
		 5.67233229 0 0 -5.67233229 0 0 -3.33100104 -0.38868967 4.72731066 -6.66200161 -0.38868961 4.72731066
		 -3.3310008 -0.77737921 4.72731066 0 -0.38868961 4.72731066 -3.3310008 0 4.72731066
		 -3.10920215 0.81471229 2.47049928 -6.16716671 0.77737921 2.36365533 -3.3310008 0.81488788 4.72731066
		 0 0.85239661 2.36365533 -2.8361659 0.81488788 0 -3.314291 0.40754953 -4.72731066
		 -6.66200161 0.38868961 -4.72731066 -3.3310008 0.81488788 -4.72731066 0 0.4261983 -4.72731066
		 -3.3310008 0 -4.72731066 -3.3310008 -0.77737921 -2.36365533 -6.66200161 -0.77737921 -2.36365533
		 -3.3310008 -0.77737921 -4.72731066 0 -0.77737921 -2.36365533 -3.3310008 -0.77737921 0
		 6.40212917 -0.38525355 2.26556587 6.66200161 -0.38868961 4.72731066 6.66200161 -0.77737921 2.36365533
		 6.16716671 -0.38868961 0 6.16716671 0 2.36365533 -6.40212917 -0.38525355 -2.26556587
		 -6.66200161 -0.38868961 -4.72731066 -6.16716671 -0.38868961 0 -6.16716671 0 -2.36365533
		 3.33100104 -0.38868967 4.72731066 3.3310008 -0.77737921 4.72731066 3.3310008 0 4.72731066
		 3.314291 0.40754953 4.72731066 6.66200161 0.38868961 4.72731066 3.3310008 0.81488788 4.72731066
		 0 0.4261983 4.72731066 -3.314291 0.40754953 4.72731066 -6.66200161 0.38868961 4.72731066
		 3.10920215 0.81471229 2.47049928 6.16716671 0.77737921 2.36365533 2.8361659 0.81488788 0
		 3.10920215 0.81471229 -2.47049928 6.16716671 0.77737921 -2.36365533 3.3310008 0.81488788 -4.72731066
		 0 0.85239661 -2.36365533 -3.10920215 0.81471229 -2.47049928 -6.16716671 0.77737921 -2.36365533
		 3.314291 0.40754953 -4.72731066 6.66200161 0.38868961 -4.72731066 3.3310008 0 -4.72731066
		 3.33100104 -0.38868967 -4.72731066 6.66200161 -0.38868961 -4.72731066 3.3310008 -0.77737921 -4.72731066
		 0 -0.38868961 -4.72731066 -3.33100104 -0.38868967 -4.72731066 3.3310008 -0.77737921 -2.36365533
		 6.66200161 -0.77737921 -2.36365533 3.3310008 -0.77737921 0 3.3310008 -0.77737921 2.36365533
		 0 -0.77737921 2.36365533 -3.3310008 -0.77737921 2.36365533 -6.66200161 -0.77737921 2.36365533
		 6.40212965 -0.38525355 -2.26556587 6.16716671 0 -2.36365533 6.16716719 0.38868961 -2.36365533
		 5.67233181 0.38868961 0 6.16716766 0.38868967 2.36365557 -6.40212965 -0.38525355 2.26556587
		 -6.16716671 0 2.36365533 -6.16716719 0.38868961 2.36365533 -5.67233181 0.38868961 0
		 -6.16716766 0.38868967 -2.36365557;
	setAttr -s 192 ".ed";
	setAttr ".ed[0:165]"  0 28 0 2 33 0 4 38 0 6 43 0 0 27 0 1 47 0 2 32 0 3 65 0
		 4 37 0 5 74 0 6 42 0 7 82 0 9 56 0 10 59 0 11 60 0 12 63 0 9 29 0 10 57 0 11 61 0
		 12 30 0 14 68 0 15 69 0 16 72 0 11 34 0 14 66 0 15 70 0 16 35 0 18 77 0 19 78 0 20 52 0
		 15 39 0 18 75 0 19 79 0 20 40 0 22 48 0 23 87 0 19 44 0 22 83 0 9 85 0 23 45 0 22 49 0
		 18 89 0 14 91 0 10 50 0 23 53 0 12 94 0 16 96 0 20 54 0 27 12 0 28 9 0 29 8 0 30 8 0
		 27 26 0 28 26 0 29 26 0 30 26 0 32 16 0 33 11 0 34 13 0 35 13 0 32 31 0 33 31 0 34 31 0
		 35 31 0 37 20 0 38 15 0 39 17 0 40 17 0 37 36 0 38 36 0 39 36 0 40 36 0 42 23 0 43 19 0
		 44 21 0 45 21 0 42 41 0 43 41 0 44 41 0 45 41 0 47 10 0 48 1 0 49 24 0 50 24 0 47 46 0
		 48 46 0 49 46 0 50 46 0 52 6 0 53 25 0 54 25 0 52 51 0 42 51 0 53 51 0 54 51 0 56 1 0
		 57 8 0 56 55 0 47 55 0 57 55 0 29 55 0 59 3 0 60 3 0 61 8 0 59 58 0 60 58 0 61 58 0
		 57 58 0 63 2 0 33 62 0 63 62 0 30 62 0 61 62 0 65 14 0 66 13 0 60 64 0 65 64 0 66 64 0
		 34 64 0 68 5 0 69 5 0 70 13 0 68 67 0 69 67 0 70 67 0 66 67 0 72 4 0 38 71 0 72 71 0
		 35 71 0 70 71 0 74 18 0 75 17 0 69 73 0 74 73 0 75 73 0 39 73 0 77 7 0 78 7 0 79 17 0
		 77 76 0 78 76 0 79 76 0 75 76 0 43 80 0 52 80 0 40 80 0 79 80 0 82 22 0 83 21 0 78 81 0
		 82 81 0 83 81 0 44 81 0 85 21 0 48 84 0 56 84 0 85 84 0 83 84 0 87 0 0 28 86 0 87 86 0
		 45 86 0 85 86 0 89 24 0 82 88 0;
	setAttr ".ed[166:191]" 77 88 0 89 88 0 49 88 0 91 24 0 74 90 0 68 90 0 91 90 0
		 89 90 0 65 92 0 59 92 0 50 92 0 91 92 0 94 25 0 87 93 0 27 93 0 94 93 0 53 93 0 96 25 0
		 63 95 0 32 95 0 96 95 0 94 95 0 72 97 0 37 97 0 54 97 0 96 97 0;
	setAttr -s 96 -ch 384 ".fc[0:95]" -type "polyFaces" 
		f 4 -20 -49 52 -56
		mu 0 4 51 19 47 46
		f 4 -27 -57 60 -64
		mu 0 4 57 25 54 52
		f 4 -34 -65 68 -72
		mu 0 4 63 31 60 58
		f 4 -40 -73 76 -80
		mu 0 4 69 37 66 64
		f 4 -44 -81 84 -88
		mu 0 4 75 17 71 70
		f 4 -48 29 91 -95
		mu 0 4 81 45 77 76
		f 4 -17 12 97 -101
		mu 0 4 50 15 83 82
		f 4 -18 13 104 -108
		mu 0 4 85 17 87 86
		f 4 -19 -58 109 -113
		mu 0 4 89 18 55 90
		f 4 -24 14 115 -119
		mu 0 4 56 18 88 92
		f 4 -25 20 122 -126
		mu 0 4 95 21 97 96
		f 4 -26 -66 127 -131
		mu 0 4 100 23 61 101
		f 4 -31 21 133 -137
		mu 0 4 62 23 99 104
		f 4 -32 27 140 -144
		mu 0 4 107 27 109 108
		f 4 -33 -74 144 -148
		mu 0 4 112 29 67 113
		f 4 -37 28 150 -154
		mu 0 4 68 29 111 115
		f 4 -38 34 155 -159
		mu 0 4 118 33 120 119
		f 4 -39 -50 160 -164
		mu 0 4 122 35 124 123
		f 4 -41 -149 165 -169
		mu 0 4 74 39 128 127
		f 4 -42 -132 170 -174
		mu 0 4 130 40 132 131
		f 4 -43 -114 174 -178
		mu 0 4 134 41 136 135
		f 4 -45 35 179 -183
		mu 0 4 80 43 138 137
		f 4 -46 15 184 -188
		mu 0 4 139 19 91 140
		f 4 -47 22 188 -192
		mu 0 4 142 44 144 143
		f 4 -5 0 53 -53
		mu 0 4 47 0 48 46
		f 4 49 16 54 -54
		mu 0 4 48 15 50 46
		f 4 50 -52 55 -55
		mu 0 4 50 14 51 46
		f 4 -7 1 61 -61
		mu 0 4 54 2 55 52
		f 4 57 23 62 -62
		mu 0 4 55 18 56 52
		f 4 58 -60 63 -63
		mu 0 4 56 20 57 52
		f 4 -9 2 69 -69
		mu 0 4 60 4 61 58
		f 4 65 30 70 -70
		mu 0 4 61 23 62 58
		f 4 66 -68 71 -71
		mu 0 4 62 26 63 58
		f 4 -11 3 77 -77
		mu 0 4 66 6 67 64
		f 4 73 36 78 -78
		mu 0 4 67 29 68 64
		f 4 74 -76 79 -79
		mu 0 4 68 32 69 64
		f 4 -6 -82 85 -85
		mu 0 4 71 1 73 70
		f 4 -35 40 86 -86
		mu 0 4 73 39 74 70
		f 4 82 -84 87 -87
		mu 0 4 74 38 75 70
		f 4 88 10 92 -92
		mu 0 4 77 12 79 76
		f 4 72 44 93 -93
		mu 0 4 79 43 80 76
		f 4 89 -91 94 -94
		mu 0 4 80 42 81 76
		f 4 95 5 98 -98
		mu 0 4 83 1 71 82
		f 4 80 17 99 -99
		mu 0 4 71 17 85 82
		f 4 96 -51 100 -100
		mu 0 4 85 14 50 82
		f 4 101 -103 105 -105
		mu 0 4 87 3 88 86
		f 4 -15 18 106 -106
		mu 0 4 88 18 89 86
		f 4 103 -97 107 -107
		mu 0 4 89 14 85 86
		f 4 -2 -109 110 -110
		mu 0 4 55 2 91 90
		f 4 -16 19 111 -111
		mu 0 4 91 19 51 90
		f 4 51 -104 112 -112
		mu 0 4 51 14 89 90
		f 4 102 7 116 -116
		mu 0 4 88 3 93 92
		f 4 113 24 117 -117
		mu 0 4 93 21 95 92
		f 4 114 -59 118 -118
		mu 0 4 95 20 56 92
		f 4 119 -121 123 -123
		mu 0 4 97 5 99 96
		f 4 -22 25 124 -124
		mu 0 4 99 23 100 96
		f 4 121 -115 125 -125
		mu 0 4 100 20 95 96
		f 4 -3 -127 128 -128
		mu 0 4 61 4 103 101
		f 4 -23 26 129 -129
		mu 0 4 103 25 57 101
		f 4 59 -122 130 -130
		mu 0 4 57 20 100 101
		f 4 120 9 134 -134
		mu 0 4 99 5 105 104
		f 4 131 31 135 -135
		mu 0 4 105 27 107 104
		f 4 132 -67 136 -136
		mu 0 4 107 26 62 104
		f 4 137 -139 141 -141
		mu 0 4 109 7 111 108
		f 4 -29 32 142 -142
		mu 0 4 111 29 112 108
		f 4 139 -133 143 -143
		mu 0 4 112 26 107 108
		f 4 -4 -89 145 -145
		mu 0 4 67 6 114 113
		f 4 -30 33 146 -146
		mu 0 4 114 31 63 113
		f 4 67 -140 147 -147
		mu 0 4 63 26 112 113
		f 4 138 11 151 -151
		mu 0 4 111 7 116 115
		f 4 148 37 152 -152
		mu 0 4 116 33 118 115
		f 4 149 -75 153 -153
		mu 0 4 118 32 68 115
		f 4 81 -96 156 -156
		mu 0 4 120 9 121 119
		f 4 -13 38 157 -157
		mu 0 4 121 35 122 119
		f 4 154 -150 158 -158
		mu 0 4 122 32 118 119
		f 4 -1 -160 161 -161
		mu 0 4 124 8 126 123
		f 4 -36 39 162 -162
		mu 0 4 126 37 69 123
		f 4 75 -155 163 -163
		mu 0 4 69 32 122 123
		f 4 -12 -138 166 -166
		mu 0 4 128 10 129 127
		f 4 -28 41 167 -167
		mu 0 4 129 40 130 127
		f 4 164 -83 168 -168
		mu 0 4 130 38 74 127
		f 4 -10 -120 171 -171
		mu 0 4 132 11 133 131
		f 4 -21 42 172 -172
		mu 0 4 133 41 134 131
		f 4 169 -165 173 -173
		mu 0 4 134 38 130 131
		f 4 -8 -102 175 -175
		mu 0 4 136 3 87 135
		f 4 -14 43 176 -176
		mu 0 4 87 17 75 135
		f 4 83 -170 177 -177
		mu 0 4 75 38 134 135
		f 4 159 4 180 -180
		mu 0 4 138 0 47 137
		f 4 48 45 181 -181
		mu 0 4 47 19 139 137
		f 4 178 -90 182 -182
		mu 0 4 139 42 80 137
		f 4 108 6 185 -185
		mu 0 4 91 2 141 140
		f 4 56 46 186 -186
		mu 0 4 141 44 142 140
		f 4 183 -179 187 -187
		mu 0 4 142 42 139 140
		f 4 126 8 189 -189
		mu 0 4 144 13 145 143
		f 4 64 47 190 -190
		mu 0 4 145 45 81 143
		f 4 90 -184 191 -191
		mu 0 4 81 42 142 143;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".bck" 3;
createNode mesh -n "polySurfaceShape1" -p "pCube5";
	rename -uid "3F37DE57-46DD-57A4-6117-1F83BDDBE46D";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -6.66200161 -0.77737921 4.72731066 6.66200161 -0.77737921 4.72731066
		 -6.66200161 0.77737921 4.72731066 6.66200161 0.77737921 4.72731066 -6.66200161 0.77737921 -4.72731066
		 6.66200161 0.77737921 -4.72731066 -6.66200161 -0.77737921 -4.72731066 6.66200161 -0.77737921 -4.72731066;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".bck" 3;
createNode transform -n "pCube6";
	rename -uid "5B05655D-4B59-BB0F-4C76-7098BF477141";
	setAttr ".t" -type "double3" -2.3809508526708565 2.2154550726943079 0.61039016282440572 ;
	setAttr ".r" -type "double3" 0 24.255890106045506 0 ;
	setAttr ".s" -type "double3" 0.39077175562793798 0.10358834263328676 0.6896572399136961 ;
createNode mesh -n "pCubeShape6" -p "pCube6";
	rename -uid "D5CD402A-411C-8A86-7BCD-22A63A236D09";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.46875 0.25 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 77 ".pt";
	setAttr ".pt[0]" -type "float3" -0.15938315 0.48068601 -0.34329277 ;
	setAttr ".pt[2]" -type "float3" 0.43864283 0 -1.1712016 ;
	setAttr ".pt[4]" -type "float3" 1.2638173 0 0.61308396 ;
	setAttr ".pt[6]" -type "float3" 0.72456706 0 0.42811394 ;
	setAttr ".pt[8]" -type "float3" 2.8411036e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[9]" -type "float3" 2.8411036e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[11]" -type "float3" 2.8411036e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[12]" -type "float3" -0.89986718 0 -2.7529726 ;
	setAttr ".pt[13]" -type "float3" 0.38427001 2.7561026 0 ;
	setAttr ".pt[15]" -type "float3" 1.4205518e-016 0 0.55595422 ;
	setAttr ".pt[16]" -type "float3" 1.2240193 2.7561026 -0.056283094 ;
	setAttr ".pt[17]" -type "float3" 1.4205518e-016 0 0.31877559 ;
	setAttr ".pt[19]" -type "float3" 1.4205518e-016 0 0.31877559 ;
	setAttr ".pt[20]" -type "float3" 0.72456706 0 0.42811394 ;
	setAttr ".pt[23]" -type "float3" -0.68135291 0 -0.26008949 ;
	setAttr ".pt[25]" -type "float3" 0.070495293 0 -0.068133205 ;
	setAttr ".pt[26]" -type "float3" 0.38427001 2.7561026 0 ;
	setAttr ".pt[27]" -type "float3" 0.39845267 2.7561026 -0.17439586 ;
	setAttr ".pt[29]" -type "float3" 0.38427001 2.7561026 0 ;
	setAttr ".pt[30]" -type "float3" 0.6613605 4.7822099 0 ;
	setAttr ".pt[32]" -type "float3" 0.53925002 0 0.18497007 ;
	setAttr ".pt[36]" -type "float3" 4.4408921e-016 3.5098684 -0.68450862 ;
	setAttr ".pt[37]" -type "float3" 4.4408921e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[39]" -type "float3" 0 4.0651417 0.19836321 ;
	setAttr ".pt[43]" -type "float3" 0.38427001 2.7561026 0.56270212 ;
	setAttr ".pt[44]" -type "float3" 0.38427001 5.6189013 0.56270212 ;
	setAttr ".pt[45]" -type "float3" 4.4408921e-016 0 0.56270212 ;
	setAttr ".pt[46]" -type "float3" 0.92352003 2.7561026 0.18497007 ;
	setAttr ".pt[56]" -type "float3" -0.34952167 0 0.43952307 ;
	setAttr ".pt[57]" -type "float3" -1.3876327 0 -0.35428005 ;
	setAttr ".pt[58]" -type "float3" 0.38427001 6.6336379 0 ;
	setAttr ".pt[59]" -type "float3" 0.38427001 2.7561026 0 ;
	setAttr ".pt[60]" -type "float3" 0.72087961 2.7561026 -0.17384309 ;
	setAttr ".pt[61]" -type "float3" 0.38427001 2.7561026 0 ;
	setAttr ".pt[62]" -type "float3" 0.38427001 4.9132762 0 ;
	setAttr ".pt[68]" -type "float3" 2.220446e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[69]" -type "float3" 2.8411036e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[70]" -type "float3" 2.220446e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[71]" -type "float3" 4.4408921e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[72]" -type "float3" 2.220446e-016 3.5098684 -0.68450862 ;
	setAttr ".pt[77]" -type "float3" 0 4.0651417 0.19836321 ;
	setAttr ".pt[78]" -type "float3" 0 2.8627985 0.56270212 ;
	setAttr ".pt[79]" -type "float3" 1.4205518e-016 0 0.56270212 ;
	setAttr ".pt[80]" -type "float3" 0 0 0.56270212 ;
	setAttr ".pt[81]" -type "float3" 0.011117007 2.8627985 0.56270212 ;
	setAttr ".pt[82]" -type "float3" 0.38427001 5.6189013 0.56270212 ;
	setAttr ".pt[93]" -type "float3" 2.9802322e-007 0 -1.1920929e-007 ;
	setAttr ".pt[95]" -type "float3" -0.17036432 1.7963732 0.081367701 ;
	setAttr ".pt[99]" -type "float3" 0.94415992 0 0 ;
	setAttr ".pt[100]" -type "float3" 0 0 -0.40582004 ;
	setAttr ".pt[102]" -type "float3" 2.220446e-016 3.3952909 -0.56954288 ;
	setAttr ".pt[103]" -type "float3" 0 0.64980185 -0.32479858 ;
	setAttr ".pt[104]" -type "float3" 0.38427001 4.3550196 -0.24474429 ;
	setAttr ".pt[105]" -type "float3" 0.38427001 4.3550196 -0.24474429 ;
	setAttr ".pt[106]" -type "float3" 0.38427001 4.3550196 -0.24474429 ;
	setAttr ".pt[107]" -type "float3" 0.38427001 2.7561026 0 ;
	setAttr ".pt[113]" -type "float3" 0 0 0.31202775 ;
	setAttr ".pt[124]" -type "float3" 4.4408921e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[125]" -type "float3" 2.220446e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[126]" -type "float3" 0 4.0651417 0.19836321 ;
	setAttr ".pt[130]" -type "float3" 4.4408921e-016 0 0.31877559 ;
	setAttr ".pt[131]" -type "float3" 0 0 0.56270212 ;
	setAttr ".pt[132]" -type "float3" 0 0 0.31877559 ;
	setAttr ".pt[133]" -type "float3" 0 4.0651417 0.7610653 ;
	setAttr ".pt[134]" -type "float3" 0 4.0651417 0.19836321 ;
	setAttr ".pt[135]" -type "float3" 0.38427001 2.7561026 0.56270212 ;
	setAttr ".pt[136]" -type "float3" 0.53925002 0 0.18497007 ;
	setAttr ".pt[137]" -type "float3" 0.53925002 0 0.18497007 ;
	setAttr ".pt[138]" -type "float3" 0.53925002 0 0.18497007 ;
	setAttr ".pt[139]" -type "float3" 0.92352003 2.7561026 0.18497007 ;
	setAttr ".pt[140]" -type "float3" 0.38427001 2.7561026 0 ;
	setAttr ".pt[141]" -type "float3" 0.65028018 2.7561026 0 ;
	setAttr ".pt[142]" -type "float3" -0.10978616 4.1040692 0.56270212 ;
	setAttr ".pt[143]" -type "float3" 0.38427001 5.1586189 0.56270212 ;
	setAttr ".pt[158]" -type "float3" 2.220446e-016 1.7963732 -0.32479858 ;
	setAttr ".pt[163]" -type "float3" -0.33557117 0 0.016160248 ;
	setAttr ".pt[167]" -type "float3" -0.94188482 0 -0.24047504 ;
	setAttr ".bck" 3;
createNode mesh -n "polySurfaceShape2" -p "pCube6";
	rename -uid "8F0D6AC6-4410-3A72-7F11-4FA66B2AAC06";
	setAttr -k off ".v";
	setAttr ".io" yes;
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.5 0.5 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -6.66200161 -0.77737921 4.72731066 6.66200161 -0.77737921 4.72731066
		 -6.66200161 0.77737921 4.72731066 6.66200161 0.77737921 4.72731066 -6.66200161 0.77737921 -4.72731066
		 6.66200161 0.77737921 -4.72731066 -6.66200161 -0.77737921 -4.72731066 6.66200161 -0.77737921 -4.72731066;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".bck" 3;
createNode transform -n "pCylinder1";
	rename -uid "CE1AE602-4987-67FE-B27A-679AC6FEACDE";
	setAttr ".t" -type "double3" -7.4919707521828531 4.1138092524082284 -6.3379305418929741 ;
	setAttr ".s" -type "double3" 0.79106150061294345 0.79106150061294345 0.79106150061294345 ;
createNode mesh -n "pCylinderShape1" -p "pCylinder1";
	rename -uid "928B0D8A-4E89-DC16-326C-2E8CF338331E";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.49999998509883881 0.15624996274709702 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 20 ".pt[0:19]" -type "float3"  0.52381516 0 -0.18932511 
		0.44558382 0 -0.36011791 0.32373524 0 -0.49565974 0.17019796 0 -0.58268291 4.7683716e-007 
		0 -0.61266905 -0.17019701 0 -0.58268291 -0.32373428 0 -0.49565962 -0.44558287 0 -0.36011776 
		-0.5238142 0 -0.18932505 -0.55077028 0 1.2498212e-007 -0.5238142 0 0.18932529 -0.44558287 
		0 0.36011797 -0.32373428 0 0.4956598 -0.17019701 0 0.58268297 4.7683716e-007 0 0.61266905 
		0.17019796 0 0.58268291 0.32373524 0 0.49565974 0.44558358 0 0.36011797 0.52381492 
		0 0.18932524 0.55077147 0 1.2498212e-007;
	setAttr ".bck" 3;
createNode transform -n "pCube7";
	rename -uid "2CD1F9A1-4C13-7347-D706-EA9998F4FDC4";
	setAttr ".t" -type "double3" -6.5537154603914178 2.8047816437906397 -5.4292297699190328 ;
	setAttr ".r" -type "double3" 0 -18.321574533334299 0 ;
	setAttr ".s" -type "double3" 0.043730006746120806 0.19183998796763826 0.096225869402965319 ;
createNode mesh -n "pCubeShape7" -p "pCube7";
	rename -uid "D822C5D0-4171-A019-CEA8-5AA9FCFCD107";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -6.66200161 -0.77737921 4.72731066 6.66200161 -0.77737921 4.72731066
		 -6.66200161 0.77737921 4.72731066 6.66200161 0.77737921 4.72731066 -6.66200161 0.77737921 -4.72731066
		 6.66200161 0.77737921 -4.72731066 -6.66200161 -0.77737921 -4.72731066 6.66200161 -0.77737921 -4.72731066;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".bck" 3;
createNode transform -n "pCube8";
	rename -uid "4C7EB9F8-4A0F-F8B8-AC7E-6B98E1D076B6";
	setAttr ".t" -type "double3" -6.1587247116417041 2.3862938109150775 -5.2957814984483207 ;
	setAttr ".r" -type "double3" 0 8.1653222502493641 0 ;
	setAttr ".s" -type "double3" 0.019492642768644087 0.028675624580597317 0.029557145112535762 ;
createNode mesh -n "pCubeShape8" -p "pCube8";
	rename -uid "148F01E4-4FFC-A52E-9A97-5791FE487188";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr -s 14 ".uvst[0].uvsp[0:13]" -type "float2" 0.375 0 0.625 0 0.375
		 0.25 0.625 0.25 0.375 0.5 0.625 0.5 0.375 0.75 0.625 0.75 0.375 1 0.625 1 0.875 0
		 0.875 0.25 0.125 0 0.125 0.25;
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 8 ".vt[0:7]"  -6.66200161 -0.77737921 4.72731066 6.66200161 -0.77737921 4.72731066
		 -6.66200161 0.77737921 4.72731066 6.66200161 0.77737921 4.72731066 -6.66200161 0.77737921 -4.72731066
		 6.66200161 0.77737921 -4.72731066 -6.66200161 -0.77737921 -4.72731066 6.66200161 -0.77737921 -4.72731066;
	setAttr -s 12 ".ed[0:11]"  0 1 0 2 3 0 4 5 0 6 7 0 0 2 0 1 3 0 2 4 0
		 3 5 0 4 6 0 5 7 0 6 0 0 7 1 0;
	setAttr -s 6 -ch 24 ".fc[0:5]" -type "polyFaces" 
		f 4 0 5 -2 -5
		mu 0 4 0 1 3 2
		f 4 1 7 -3 -7
		mu 0 4 2 3 5 4
		f 4 2 9 -4 -9
		mu 0 4 4 5 7 6
		f 4 3 11 -1 -11
		mu 0 4 6 7 9 8
		f 4 -12 -10 -8 -6
		mu 0 4 1 10 11 3
		f 4 10 4 6 8
		mu 0 4 12 0 2 13;
	setAttr ".cd" -type "dataPolyComponent" Index_Data Edge 0 ;
	setAttr ".cvd" -type "dataPolyComponent" Index_Data Vertex 0 ;
	setAttr ".pd[0]" -type "dataPolyComponent" Index_Data UV 0 ;
	setAttr ".hfd" -type "dataPolyComponent" Index_Data Face 0 ;
	setAttr ".bck" 3;
createNode transform -n "pCube9";
	rename -uid "2163C6AB-470E-E454-4DDC-C8956DE07349";
	setAttr ".t" -type "double3" -4.3852824026783175 2.8109754704971373 2.5839178551140529 ;
	setAttr ".r" -type "double3" 18.256038063097076 -34.251931859951 -7.4914526742177747 ;
	setAttr ".s" -type "double3" 0.26838153480786253 0.31430983364341197 0.88655233610516826 ;
createNode mesh -n "pCubeShape9" -p "pCube9";
	rename -uid "6208ECDF-4736-F82D-7B20-38AEA832469E";
	setAttr -k off ".v";
	setAttr ".vir" yes;
	setAttr ".vif" yes;
	setAttr ".pv" -type "double2" 0.48127320408821106 0.625 ;
	setAttr ".uvst[0].uvsn" -type "string" "map1";
	setAttr ".cuvs" -type "string" "map1";
	setAttr ".dcc" -type "string" "Ambient+Diffuse";
	setAttr ".covm[0]"  0 1 1;
	setAttr ".cdvm[0]"  0 1 1;
	setAttr -s 46 ".pt";
	setAttr ".pt[0]" -type "float3" 0.2039873 -0.63234729 -0.039320163 ;
	setAttr ".pt[1]" -type "float3" 0.33397919 -0.63234729 0.023714671 ;
	setAttr ".pt[2]" -type "float3" 0.33397919 -0.63234729 0.023714671 ;
	setAttr ".pt[3]" -type "float3" 0.072143108 -0.63234729 0.023714671 ;
	setAttr ".pt[4]" -type "float3" 0.2039873 -0.63234729 -0.039320163 ;
	setAttr ".pt[5]" -type "float3" 0.33397919 -0.63234729 0.023714671 ;
	setAttr ".pt[6]" -type "float3" 0.33397919 -0.63234729 0.023714671 ;
	setAttr ".pt[7]" -type "float3" 0.072143115 -0.63234729 0.023714671 ;
	setAttr ".pt[8]" -type "float3" 0.29946262 0.23355238 -0.040718019 ;
	setAttr ".pt[9]" -type "float3" 0.29946262 0.23355238 -0.040718019 ;
	setAttr ".pt[10]" -type "float3" 0.29946262 0.23355238 -0.040718019 ;
	setAttr ".pt[11]" -type "float3" 0.29946262 0.23355238 -0.040718019 ;
	setAttr ".pt[12]" -type "float3" 0.29946262 0.23355238 -0.040718019 ;
	setAttr ".pt[13]" -type "float3" -0.022505134 0.20681664 -0.0044362843 ;
	setAttr ".pt[14]" -type "float3" -0.022505134 0.20681664 -0.0044362247 ;
	setAttr ".pt[15]" -type "float3" -0.022505164 0.20681664 -0.0044362396 ;
	setAttr ".pt[16]" -type "float3" -0.022505119 0.20681664 -0.0044362247 ;
	setAttr ".pt[17]" -type "float3" -0.022505134 0.20681664 -0.0044362247 ;
	setAttr ".pt[18]" -type "float3" 0.026803253 -0.31198782 -0.0024503116 ;
	setAttr ".pt[19]" -type "float3" 0.026803253 -0.31198782 -0.0024503116 ;
	setAttr ".pt[20]" -type "float3" 0.026803253 -0.31198782 -0.0024503116 ;
	setAttr ".pt[21]" -type "float3" 0.026803253 -0.31198782 -0.0024503116 ;
	setAttr ".pt[22]" -type "float3" 0.026803253 -0.28827852 0.049631327 ;
	setAttr ".pt[23]" -type "float3" 0.026803253 -0.28827852 0.049631327 ;
	setAttr ".pt[24]" -type "float3" 0.026803253 -0.28827852 0.049631327 ;
	setAttr ".pt[25]" -type "float3" 0.026803253 -0.28827852 0.049631327 ;
	setAttr ".pt[26]" -type "float3" -0.022505134 0.20681664 -0.0044362843 ;
	setAttr ".pt[27]" -type "float3" -0.022505134 0.20681664 -0.0044362247 ;
	setAttr ".pt[28]" -type "float3" -0.022505164 0.20681664 -0.0044362396 ;
	setAttr ".pt[29]" -type "float3" -0.022505119 0.20681664 -0.0044362247 ;
	setAttr ".pt[30]" -type "float3" -0.022505134 0.20681664 -0.0044362247 ;
	setAttr ".pt[31]" -type "float3" 0.29946262 0.23355238 -0.040718019 ;
	setAttr ".pt[32]" -type "float3" 0.29946262 0.23355238 -0.040718019 ;
	setAttr ".pt[33]" -type "float3" 0.29946262 0.23355238 -0.040718019 ;
	setAttr ".pt[34]" -type "float3" 0.29946262 0.23355238 -0.040718019 ;
	setAttr ".pt[35]" -type "float3" 0.29946262 0.23355238 -0.040718019 ;
	setAttr ".pt[37]" -type "float3" 0.072143108 -0.63234729 0.023714671 ;
	setAttr ".pt[38]" -type "float3" 0.23636262 -0.63234729 0.023714671 ;
	setAttr ".pt[39]" -type "float3" 0.23636262 -0.63234729 0.023714671 ;
	setAttr ".pt[40]" -type "float3" 0.23636262 -0.63234729 0.023714671 ;
	setAttr ".pt[42]" -type "float3" 0.23636262 -0.63234729 0.023714671 ;
	setAttr ".pt[43]" -type "float3" 0.23636262 -0.63234729 0.023714671 ;
	setAttr ".pt[44]" -type "float3" 0.23636262 -0.63234729 0.023714671 ;
	setAttr ".pt[45]" -type "float3" 0.072143108 -0.63234729 0.023714671 ;
	setAttr ".pt[49]" -type "float3" 0.026803253 -0.12140689 -0.013355161 ;
	setAttr ".pt[52]" -type "float3" 0.026803253 -0.097697653 0.038726483 ;
	setAttr ".bck" 3;
createNode lightLinker -s -n "lightLinker1";
	rename -uid "D5F079A9-4022-0869-E0F9-43B0C8A9127D";
	setAttr -s 2 ".lnk";
	setAttr -s 2 ".slnk";
createNode displayLayerManager -n "layerManager";
	rename -uid "4A58CE30-460B-EC72-0F78-D2BB1CE3FA77";
createNode displayLayer -n "defaultLayer";
	rename -uid "E76501EE-4DF9-0413-8A9A-B183237B1C62";
createNode renderLayerManager -n "renderLayerManager";
	rename -uid "E88D582D-4F14-9C41-B29F-4FBB3CA4A7A6";
createNode renderLayer -n "defaultRenderLayer";
	rename -uid "AC7EE211-4852-23F2-01E7-D7A539EB067E";
	setAttr ".g" yes;
createNode polyCube -n "polyCube1";
	rename -uid "F165743B-48F8-D490-B90F-AFA408C24E69";
	setAttr ".w" 13.324003598658203;
	setAttr ".h" 1.5547584193204265;
	setAttr ".d" 9.4546210746002242;
	setAttr ".cuv" 4;
createNode polySubdFace -n "polySubdFace1";
	rename -uid "56BF57F6-4749-B039-FF6D-15BFF4D97411";
	setAttr ".ics" -type "componentList" 1 "f[*]";
createNode createColorSet -n "createColorSet1";
	rename -uid "5E6E711D-4B76-22EA-19D7-41A592A8CFBC";
	setAttr ".colos" -type "string" "SculptFreezeColorTemp";
	setAttr ".clam" no;
createNode polySubdFace -n "polySubdFace2";
	rename -uid "FE37EC12-4C6C-1A04-9952-E6BE1F653F66";
	setAttr ".ics" -type "componentList" 1 "f[*]";
createNode polyTweak -n "polyTweak1";
	rename -uid "A112A2FC-484B-730F-00F1-8CB5CB339C7B";
	setAttr ".uopa" yes;
	setAttr -s 15 ".tk[11:25]" -type "float3"  0 0.075017378 0 0 0 0 0 0.075017378
		 0 -0.98966956 0 0 0 0.075017378 0 0.98966956 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0
		 0 0 0 0 0 -0.98966962 0 0 0.98966962 0 0;
createNode polyCylinder -n "polyCylinder1";
	rename -uid "AC6EA087-44F2-C268-309B-40A27D41D6EB";
	setAttr ".r" 0.73046280746986036;
	setAttr ".h" 1.1814718847936079;
	setAttr ".sc" 1;
	setAttr ".cuv" 3;
createNode polySubdFace -n "polySubdFace3";
	rename -uid "D39B7978-4E86-88C5-820D-B7A5ED03DB1C";
	setAttr ".ics" -type "componentList" 1 "f[*]";
createNode polySubdFace -n "polySubdFace4";
	rename -uid "6A2394D1-41EA-09AB-2920-9089F80EE367";
	setAttr ".ics" -type "componentList" 4 "f[1]" "f[3]" "f[9:11]" "f[15:17]";
createNode polySubdFace -n "polySubdFace5";
	rename -uid "D5629740-4E0E-F736-59C8-FE9E601D8CF8";
	setAttr ".ics" -type "componentList" 5 "f[1]" "f[3]" "f[9:11]" "f[15:17]" "f[24:47]";
createNode script -n "uiConfigurationScriptNode";
	rename -uid "EE661989-4C6D-F6A2-C4C8-C0B5583DA1BA";
	setAttr ".b" -type "string" (
		"// Maya Mel UI Configuration File.\n//\n//  This script is machine generated.  Edit at your own risk.\n//\n//\n\nglobal string $gMainPane;\nif (`paneLayout -exists $gMainPane`) {\n\n\tglobal int $gUseScenePanelConfig;\n\tint    $useSceneConfig = $gUseScenePanelConfig;\n\tint    $menusOkayInPanels = `optionVar -q allowMenusInPanels`;\tint    $nVisPanes = `paneLayout -q -nvp $gMainPane`;\n\tint    $nPanes = 0;\n\tstring $editorName;\n\tstring $panelName;\n\tstring $itemFilterName;\n\tstring $panelConfig;\n\n\t//\n\t//  get current state of the UI\n\t//\n\tsceneUIReplacement -update $gMainPane;\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Top View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"top\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"smoothShaded\" \n"
		+ "                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n                -holdOuts 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 0\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 16384\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -depthOfFieldPreview 1\n                -maxConstantTransparency 1\n"
		+ "                -rendererName \"vp2Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n"
		+ "                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -particleInstancers 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                -captureSequenceNumber -1\n                -width 1\n                -height 1\n                -sceneRenderFilter 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n"
		+ "                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Top View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"top\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n"
		+ "            -textureMaxSize 16384\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n"
		+ "            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n"
		+ "        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Side View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"side\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"smoothShaded\" \n                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n                -holdOuts 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 0\n                -backfaceCulling 0\n"
		+ "                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 16384\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -depthOfFieldPreview 1\n                -maxConstantTransparency 1\n                -rendererName \"vp2Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n"
		+ "                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -particleInstancers 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n"
		+ "                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                -captureSequenceNumber -1\n                -width 1\n                -height 1\n                -sceneRenderFilter 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Side View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"side\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n"
		+ "            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 16384\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n"
		+ "            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n"
		+ "            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Front View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels `;\n"
		+ "\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"front\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"smoothShaded\" \n                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n                -holdOuts 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 0\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 16384\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n"
		+ "                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -depthOfFieldPreview 1\n                -maxConstantTransparency 1\n                -rendererName \"vp2Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n"
		+ "                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -particleInstancers 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                -captureSequenceNumber -1\n"
		+ "                -width 1\n                -height 1\n                -sceneRenderFilter 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Front View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"front\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n"
		+ "            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 16384\n            -fogging 0\n            -fogSource \"fragment\" \n            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n"
		+ "            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n"
		+ "            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1\n            -height 1\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"modelPanel\" (localizedPanelLabel(\"Persp View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `modelPanel -unParent -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            modelEditor -e \n                -camera \"persp\" \n                -useInteractiveMode 0\n                -displayLights \"default\" \n                -displayAppearance \"smoothShaded\" \n                -activeOnly 0\n                -ignorePanZoom 0\n                -wireframeOnShaded 0\n                -headsUpDisplay 1\n"
		+ "                -holdOuts 1\n                -selectionHiliteDisplay 1\n                -useDefaultMaterial 0\n                -bufferMode \"double\" \n                -twoSidedLighting 0\n                -backfaceCulling 0\n                -xray 0\n                -jointXray 0\n                -activeComponentsXray 0\n                -displayTextures 0\n                -smoothWireframe 0\n                -lineWidth 1\n                -textureAnisotropic 0\n                -textureHilight 1\n                -textureSampling 2\n                -textureDisplay \"modulate\" \n                -textureMaxSize 16384\n                -fogging 0\n                -fogSource \"fragment\" \n                -fogMode \"linear\" \n                -fogStart 0\n                -fogEnd 100\n                -fogDensity 0.1\n                -fogColor 0.5 0.5 0.5 1 \n                -depthOfFieldPreview 1\n                -maxConstantTransparency 1\n                -rendererName \"vp2Renderer\" \n                -objectFilterShowInHUD 1\n                -isFiltered 0\n"
		+ "                -colorResolution 256 256 \n                -bumpResolution 512 512 \n                -textureCompression 0\n                -transparencyAlgorithm \"frontAndBackCull\" \n                -transpInShadows 0\n                -cullingOverride \"none\" \n                -lowQualityLighting 0\n                -maximumNumHardwareLights 1\n                -occlusionCulling 0\n                -shadingModel 0\n                -useBaseRenderer 0\n                -useReducedRenderer 0\n                -smallObjectCulling 0\n                -smallObjectThreshold -1 \n                -interactiveDisableShadows 0\n                -interactiveBackFaceCull 0\n                -sortTransparent 1\n                -nurbsCurves 1\n                -nurbsSurfaces 1\n                -polymeshes 1\n                -subdivSurfaces 1\n                -planes 1\n                -lights 1\n                -cameras 1\n                -controlVertices 1\n                -hulls 1\n                -grid 1\n                -imagePlane 1\n                -joints 1\n"
		+ "                -ikHandles 1\n                -deformers 1\n                -dynamics 1\n                -particleInstancers 1\n                -fluids 1\n                -hairSystems 1\n                -follicles 1\n                -nCloths 1\n                -nParticles 1\n                -nRigids 1\n                -dynamicConstraints 1\n                -locators 1\n                -manipulators 1\n                -pluginShapes 1\n                -dimensions 1\n                -handles 1\n                -pivots 1\n                -textures 1\n                -strokes 1\n                -motionTrails 1\n                -clipGhosts 1\n                -greasePencils 1\n                -shadows 0\n                -captureSequenceNumber -1\n                -width 1079\n                -height 716\n                -sceneRenderFilter 0\n                $editorName;\n            modelEditor -e -viewSelected 0 $editorName;\n            modelEditor -e \n                -pluginObjects \"gpuCacheDisplayFilter\" 1 \n                $editorName;\n\t\t}\n\t} else {\n"
		+ "\t\t$label = `panel -q -label $panelName`;\n\t\tmodelPanel -edit -l (localizedPanelLabel(\"Persp View\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        modelEditor -e \n            -camera \"persp\" \n            -useInteractiveMode 0\n            -displayLights \"default\" \n            -displayAppearance \"smoothShaded\" \n            -activeOnly 0\n            -ignorePanZoom 0\n            -wireframeOnShaded 0\n            -headsUpDisplay 1\n            -holdOuts 1\n            -selectionHiliteDisplay 1\n            -useDefaultMaterial 0\n            -bufferMode \"double\" \n            -twoSidedLighting 0\n            -backfaceCulling 0\n            -xray 0\n            -jointXray 0\n            -activeComponentsXray 0\n            -displayTextures 0\n            -smoothWireframe 0\n            -lineWidth 1\n            -textureAnisotropic 0\n            -textureHilight 1\n            -textureSampling 2\n            -textureDisplay \"modulate\" \n            -textureMaxSize 16384\n            -fogging 0\n            -fogSource \"fragment\" \n"
		+ "            -fogMode \"linear\" \n            -fogStart 0\n            -fogEnd 100\n            -fogDensity 0.1\n            -fogColor 0.5 0.5 0.5 1 \n            -depthOfFieldPreview 1\n            -maxConstantTransparency 1\n            -rendererName \"vp2Renderer\" \n            -objectFilterShowInHUD 1\n            -isFiltered 0\n            -colorResolution 256 256 \n            -bumpResolution 512 512 \n            -textureCompression 0\n            -transparencyAlgorithm \"frontAndBackCull\" \n            -transpInShadows 0\n            -cullingOverride \"none\" \n            -lowQualityLighting 0\n            -maximumNumHardwareLights 1\n            -occlusionCulling 0\n            -shadingModel 0\n            -useBaseRenderer 0\n            -useReducedRenderer 0\n            -smallObjectCulling 0\n            -smallObjectThreshold -1 \n            -interactiveDisableShadows 0\n            -interactiveBackFaceCull 0\n            -sortTransparent 1\n            -nurbsCurves 1\n            -nurbsSurfaces 1\n            -polymeshes 1\n            -subdivSurfaces 1\n"
		+ "            -planes 1\n            -lights 1\n            -cameras 1\n            -controlVertices 1\n            -hulls 1\n            -grid 1\n            -imagePlane 1\n            -joints 1\n            -ikHandles 1\n            -deformers 1\n            -dynamics 1\n            -particleInstancers 1\n            -fluids 1\n            -hairSystems 1\n            -follicles 1\n            -nCloths 1\n            -nParticles 1\n            -nRigids 1\n            -dynamicConstraints 1\n            -locators 1\n            -manipulators 1\n            -pluginShapes 1\n            -dimensions 1\n            -handles 1\n            -pivots 1\n            -textures 1\n            -strokes 1\n            -motionTrails 1\n            -clipGhosts 1\n            -greasePencils 1\n            -shadows 0\n            -captureSequenceNumber -1\n            -width 1079\n            -height 716\n            -sceneRenderFilter 0\n            $editorName;\n        modelEditor -e -viewSelected 0 $editorName;\n        modelEditor -e \n            -pluginObjects \"gpuCacheDisplayFilter\" 1 \n"
		+ "            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"outlinerPanel\" (localizedPanelLabel(\"Outliner\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `outlinerPanel -unParent -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels `;\n\t\t\t$editorName = $panelName;\n            outlinerEditor -e \n                -showShapes 0\n                -showReferenceNodes 1\n                -showReferenceMembers 1\n                -showAttributes 0\n                -showConnected 0\n                -showAnimCurvesOnly 0\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 1\n                -showAssets 1\n                -showContainedOnly 1\n                -showPublishedAsConnected 0\n                -showContainerContents 1\n                -ignoreDagHierarchy 0\n                -expandConnections 0\n"
		+ "                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 0\n                -highlightActive 1\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"defaultSetFilter\" \n                -showSetMembers 1\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n"
		+ "                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 0\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\toutlinerPanel -edit -l (localizedPanelLabel(\"Outliner\")) -mbv $menusOkayInPanels  $panelName;\n\t\t$editorName = $panelName;\n        outlinerEditor -e \n            -showShapes 0\n            -showReferenceNodes 1\n            -showReferenceMembers 1\n            -showAttributes 0\n            -showConnected 0\n            -showAnimCurvesOnly 0\n            -showMuteInfo 0\n            -organizeByLayer 1\n            -showAnimLayerWeight 1\n            -autoExpandLayers 1\n            -autoExpand 0\n            -showDagOnly 1\n            -showAssets 1\n            -showContainedOnly 1\n            -showPublishedAsConnected 0\n            -showContainerContents 1\n            -ignoreDagHierarchy 0\n            -expandConnections 0\n            -showUpstreamCurves 1\n"
		+ "            -showUnitlessCurves 1\n            -showCompounds 1\n            -showLeafs 1\n            -showNumericAttrsOnly 0\n            -highlightActive 1\n            -autoSelectNewObjects 0\n            -doNotSelectNewObjects 0\n            -dropIsParent 1\n            -transmitFilters 0\n            -setFilter \"defaultSetFilter\" \n            -showSetMembers 1\n            -allowMultiSelection 1\n            -alwaysToggleSelect 0\n            -directSelect 0\n            -displayMode \"DAG\" \n            -expandObjects 0\n            -setsIgnoreFilters 1\n            -containersIgnoreFilters 0\n            -editAttrName 0\n            -showAttrValues 0\n            -highlightSecondary 0\n            -showUVAttrsOnly 0\n            -showTextureNodesOnly 0\n            -attrAlphaOrder \"default\" \n            -animLayerFilterOptions \"allAffecting\" \n            -sortOrder \"none\" \n            -longNames 0\n            -niceNames 1\n            -showNamespace 1\n            -showPinIcons 0\n            -mapMotionTrails 0\n            -ignoreHiddenAttribute 0\n"
		+ "            -ignoreOutlinerColor 0\n            $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"graphEditor\" (localizedPanelLabel(\"Graph Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"graphEditor\" -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n"
		+ "                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n"
		+ "                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 1\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showResults \"off\" \n                -showBufferCurves \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -stackedCurves 0\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n"
		+ "                -stackedCurvesSpace 0.2\n                -displayNormalized 0\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -classicMode 1\n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Graph Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 1\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n"
		+ "                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 1\n                -showCompounds 0\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 1\n                -doNotSelectNewObjects 0\n                -dropIsParent 1\n                -transmitFilters 1\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n"
		+ "                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 1\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"GraphEd\");\n            animCurveEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 1\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -showResults \"off\" \n                -showBufferCurves \"off\" \n                -smoothness \"fine\" \n                -resultSamples 1\n                -resultScreenSamples 0\n                -resultUpdate \"delayed\" \n                -showUpstreamCurves 1\n                -stackedCurves 0\n                -stackedCurvesMin -1\n                -stackedCurvesMax 1\n                -stackedCurvesSpace 0.2\n"
		+ "                -displayNormalized 0\n                -preSelectionHighlight 0\n                -constrainDrag 0\n                -classicMode 1\n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dopeSheetPanel\" (localizedPanelLabel(\"Dope Sheet\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"dopeSheetPanel\" -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n"
		+ "                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n"
		+ "                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                $editorName;\n\n\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n"
		+ "\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dope Sheet\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"OutlineEd\");\n            outlinerEditor -e \n                -showShapes 1\n                -showReferenceNodes 0\n                -showReferenceMembers 0\n                -showAttributes 1\n                -showConnected 1\n                -showAnimCurvesOnly 1\n                -showMuteInfo 0\n                -organizeByLayer 1\n                -showAnimLayerWeight 1\n                -autoExpandLayers 1\n                -autoExpand 0\n                -showDagOnly 0\n                -showAssets 1\n                -showContainedOnly 0\n                -showPublishedAsConnected 0\n                -showContainerContents 0\n                -ignoreDagHierarchy 0\n                -expandConnections 1\n                -showUpstreamCurves 1\n                -showUnitlessCurves 0\n                -showCompounds 1\n                -showLeafs 1\n                -showNumericAttrsOnly 1\n                -highlightActive 0\n"
		+ "                -autoSelectNewObjects 0\n                -doNotSelectNewObjects 1\n                -dropIsParent 1\n                -transmitFilters 0\n                -setFilter \"0\" \n                -showSetMembers 0\n                -allowMultiSelection 1\n                -alwaysToggleSelect 0\n                -directSelect 0\n                -displayMode \"DAG\" \n                -expandObjects 0\n                -setsIgnoreFilters 1\n                -containersIgnoreFilters 0\n                -editAttrName 0\n                -showAttrValues 0\n                -highlightSecondary 0\n                -showUVAttrsOnly 0\n                -showTextureNodesOnly 0\n                -attrAlphaOrder \"default\" \n                -animLayerFilterOptions \"allAffecting\" \n                -sortOrder \"none\" \n                -longNames 0\n                -niceNames 1\n                -showNamespace 1\n                -showPinIcons 0\n                -mapMotionTrails 1\n                -ignoreHiddenAttribute 0\n                -ignoreOutlinerColor 0\n                $editorName;\n"
		+ "\t\t\t$editorName = ($panelName+\"DopeSheetEd\");\n            dopeSheetEditor -e \n                -displayKeys 1\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"integer\" \n                -snapValue \"none\" \n                -outliner \"dopeSheetPanel1OutlineEd\" \n                -showSummary 1\n                -showScene 0\n                -hierarchyBelow 0\n                -showTicks 1\n                -selectionWindow 0 0 0 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"clipEditorPanel\" (localizedPanelLabel(\"Trax Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"clipEditorPanel\" -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n"
		+ "            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -manageSequencer 0 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Trax Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = clipEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -manageSequencer 0 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"sequenceEditorPanel\" (localizedPanelLabel(\"Camera Sequencer\")) `;\n"
		+ "\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"sequenceEditorPanel\" -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -manageSequencer 1 \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Camera Sequencer\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = sequenceEditorNameFromPanel($panelName);\n            clipEditor -e \n                -displayKeys 0\n                -displayTangents 0\n                -displayActiveKeys 0\n                -displayActiveKeyTangents 0\n                -displayInfinities 0\n"
		+ "                -autoFit 0\n                -snapTime \"none\" \n                -snapValue \"none\" \n                -manageSequencer 1 \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperGraphPanel\" (localizedPanelLabel(\"Hypergraph Hierarchy\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"hyperGraphPanel\" -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n"
		+ "                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypergraph Hierarchy\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"HyperGraphEd\");\n            hyperGraph -e \n                -graphLayoutStyle \"hierarchicalLayout\" \n                -orientation \"horiz\" \n"
		+ "                -mergeConnections 0\n                -zoom 1\n                -animateTransition 0\n                -showRelationships 1\n                -showShapes 0\n                -showDeformers 0\n                -showExpressions 0\n                -showConstraints 0\n                -showConnectionFromSelected 0\n                -showConnectionToSelected 0\n                -showConstraintLabels 0\n                -showUnderworld 0\n                -showInvisible 0\n                -transitionFrames 1\n                -opaqueContainers 0\n                -freeform 0\n                -imagePosition 0 0 \n                -imageScale 1\n                -imageEnabled 0\n                -graphType \"DAG\" \n                -heatMapDisplay 0\n                -updateSelection 1\n                -updateNodeAdded 1\n                -useDrawOverrideColor 0\n                -limitGraphTraversal -1\n                -range 0 0 \n                -iconSize \"smallIcons\" \n                -showCachedConnections 0\n                $editorName;\n\t\tif (!$useSceneConfig) {\n"
		+ "\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"visorPanel\" (localizedPanelLabel(\"Visor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"visorPanel\" -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Visor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"createNodePanel\" (localizedPanelLabel(\"Create Node\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"createNodePanel\" -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Create Node\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"polyTexturePlacementPanel\" (localizedPanelLabel(\"UV Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"polyTexturePlacementPanel\" -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"UV Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"renderWindowPanel\" (localizedPanelLabel(\"Render View\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"renderWindowPanel\" -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Render View\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n"
		+ "\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextPanel \"blendShapePanel\" (localizedPanelLabel(\"Blend Shape\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\tblendShapePanel -unParent -l (localizedPanelLabel(\"Blend Shape\")) -mbv $menusOkayInPanels ;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tblendShapePanel -edit -l (localizedPanelLabel(\"Blend Shape\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynRelEdPanel\" (localizedPanelLabel(\"Dynamic Relationships\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"dynRelEdPanel\" -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Dynamic Relationships\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n"
		+ "\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"relationshipPanel\" (localizedPanelLabel(\"Relationship Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"relationshipPanel\" -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Relationship Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"referenceEditorPanel\" (localizedPanelLabel(\"Reference Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"referenceEditorPanel\" -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Reference Editor\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"componentEditorPanel\" (localizedPanelLabel(\"Component Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"componentEditorPanel\" -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Component Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"dynPaintScriptedPanelType\" (localizedPanelLabel(\"Paint Effects\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"dynPaintScriptedPanelType\" -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Paint Effects\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"scriptEditorPanel\" (localizedPanelLabel(\"Script Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"scriptEditorPanel\" -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Script Editor\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"profilerPanel\" (localizedPanelLabel(\"Profiler Tool\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"profilerPanel\" -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Profiler Tool\")) -mbv $menusOkayInPanels  $panelName;\n"
		+ "\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"hyperShadePanel\" (localizedPanelLabel(\"Hypershade\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"hyperShadePanel\" -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels `;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Hypershade\")) -mbv $menusOkayInPanels  $panelName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\t$panelName = `sceneUIReplacement -getNextScriptedPanel \"nodeEditorPanel\" (localizedPanelLabel(\"Node Editor\")) `;\n\tif (\"\" == $panelName) {\n\t\tif ($useSceneConfig) {\n\t\t\t$panelName = `scriptedPanel -unParent  -type \"nodeEditorPanel\" -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels `;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n"
		+ "                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -activeTab -1\n                -editorMode \"default\" \n                $editorName;\n\t\t}\n\t} else {\n\t\t$label = `panel -q -label $panelName`;\n\t\tscriptedPanel -edit -l (localizedPanelLabel(\"Node Editor\")) -mbv $menusOkayInPanels  $panelName;\n\n\t\t\t$editorName = ($panelName+\"NodeEditorEd\");\n            nodeEditor -e \n"
		+ "                -allAttributes 0\n                -allNodes 0\n                -autoSizeNodes 1\n                -consistentNameSize 1\n                -createNodeCommand \"nodeEdCreateNodeCommand\" \n                -defaultPinnedState 0\n                -additiveGraphingMode 0\n                -settingsChangedCallback \"nodeEdSyncControls\" \n                -traversalDepthLimit -1\n                -keyPressCommand \"nodeEdKeyPressCommand\" \n                -nodeTitleMode \"name\" \n                -gridSnap 0\n                -gridVisibility 1\n                -popupMenuScript \"nodeEdBuildPanelMenus\" \n                -showNamespace 1\n                -showShapes 1\n                -showSGShapes 0\n                -showTransforms 1\n                -useAssets 1\n                -syncedSelection 1\n                -extendToShapes 1\n                -activeTab -1\n                -editorMode \"default\" \n                $editorName;\n\t\tif (!$useSceneConfig) {\n\t\t\tpanel -e -l $label $panelName;\n\t\t}\n\t}\n\n\n\tif ($useSceneConfig) {\n        string $configName = `getPanel -cwl (localizedPanelLabel(\"Current Layout\"))`;\n"
		+ "        if (\"\" != $configName) {\n\t\t\tpanelConfiguration -edit -label (localizedPanelLabel(\"Current Layout\")) \n\t\t\t\t-defaultImage \"\"\n\t\t\t\t-image \"\"\n\t\t\t\t-sc false\n\t\t\t\t-configString \"global string $gMainPane; paneLayout -e -cn \\\"single\\\" -ps 1 100 100 $gMainPane;\"\n\t\t\t\t-removeAllPanels\n\t\t\t\t-ap false\n\t\t\t\t\t(localizedPanelLabel(\"Persp View\")) \n\t\t\t\t\t\"modelPanel\"\n"
		+ "\t\t\t\t\t\"$panelName = `modelPanel -unParent -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels `;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 16384\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1079\\n    -height 716\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t\t\"modelPanel -edit -l (localizedPanelLabel(\\\"Persp View\\\")) -mbv $menusOkayInPanels  $panelName;\\n$editorName = $panelName;\\nmodelEditor -e \\n    -cam `findStartUpCamera persp` \\n    -useInteractiveMode 0\\n    -displayLights \\\"default\\\" \\n    -displayAppearance \\\"smoothShaded\\\" \\n    -activeOnly 0\\n    -ignorePanZoom 0\\n    -wireframeOnShaded 0\\n    -headsUpDisplay 1\\n    -holdOuts 1\\n    -selectionHiliteDisplay 1\\n    -useDefaultMaterial 0\\n    -bufferMode \\\"double\\\" \\n    -twoSidedLighting 0\\n    -backfaceCulling 0\\n    -xray 0\\n    -jointXray 0\\n    -activeComponentsXray 0\\n    -displayTextures 0\\n    -smoothWireframe 0\\n    -lineWidth 1\\n    -textureAnisotropic 0\\n    -textureHilight 1\\n    -textureSampling 2\\n    -textureDisplay \\\"modulate\\\" \\n    -textureMaxSize 16384\\n    -fogging 0\\n    -fogSource \\\"fragment\\\" \\n    -fogMode \\\"linear\\\" \\n    -fogStart 0\\n    -fogEnd 100\\n    -fogDensity 0.1\\n    -fogColor 0.5 0.5 0.5 1 \\n    -depthOfFieldPreview 1\\n    -maxConstantTransparency 1\\n    -rendererName \\\"vp2Renderer\\\" \\n    -objectFilterShowInHUD 1\\n    -isFiltered 0\\n    -colorResolution 256 256 \\n    -bumpResolution 512 512 \\n    -textureCompression 0\\n    -transparencyAlgorithm \\\"frontAndBackCull\\\" \\n    -transpInShadows 0\\n    -cullingOverride \\\"none\\\" \\n    -lowQualityLighting 0\\n    -maximumNumHardwareLights 1\\n    -occlusionCulling 0\\n    -shadingModel 0\\n    -useBaseRenderer 0\\n    -useReducedRenderer 0\\n    -smallObjectCulling 0\\n    -smallObjectThreshold -1 \\n    -interactiveDisableShadows 0\\n    -interactiveBackFaceCull 0\\n    -sortTransparent 1\\n    -nurbsCurves 1\\n    -nurbsSurfaces 1\\n    -polymeshes 1\\n    -subdivSurfaces 1\\n    -planes 1\\n    -lights 1\\n    -cameras 1\\n    -controlVertices 1\\n    -hulls 1\\n    -grid 1\\n    -imagePlane 1\\n    -joints 1\\n    -ikHandles 1\\n    -deformers 1\\n    -dynamics 1\\n    -particleInstancers 1\\n    -fluids 1\\n    -hairSystems 1\\n    -follicles 1\\n    -nCloths 1\\n    -nParticles 1\\n    -nRigids 1\\n    -dynamicConstraints 1\\n    -locators 1\\n    -manipulators 1\\n    -pluginShapes 1\\n    -dimensions 1\\n    -handles 1\\n    -pivots 1\\n    -textures 1\\n    -strokes 1\\n    -motionTrails 1\\n    -clipGhosts 1\\n    -greasePencils 1\\n    -shadows 0\\n    -captureSequenceNumber -1\\n    -width 1079\\n    -height 716\\n    -sceneRenderFilter 0\\n    $editorName;\\nmodelEditor -e -viewSelected 0 $editorName;\\nmodelEditor -e \\n    -pluginObjects \\\"gpuCacheDisplayFilter\\\" 1 \\n    $editorName\"\n"
		+ "\t\t\t\t$configName;\n\n            setNamedPanelLayout (localizedPanelLabel(\"Current Layout\"));\n        }\n\n        panelHistory -e -clear mainPanelHistory;\n        setFocus `paneLayout -q -p1 $gMainPane`;\n        sceneUIReplacement -deleteRemaining;\n        sceneUIReplacement -clear;\n\t}\n\n\ngrid -spacing 5 -size 12 -divisions 5 -displayAxes yes -displayGridLines yes -displayDivisionLines yes -displayPerspectiveLabels no -displayOrthographicLabels no -displayAxesBold yes -perspectiveLabelPosition axis -orthographicLabelPosition edge;\nviewManip -drawCompass 0 -compassAngle 0 -frontParameters \"\" -homeParameters \"\" -selectionLockParameters \"\";\n}\n");
	setAttr ".st" 3;
createNode script -n "sceneConfigurationScriptNode";
	rename -uid "8AA8DD07-4C78-F016-CA0C-ACA8C93AFDB8";
	setAttr ".b" -type "string" "playbackOptions -min 1 -max 120 -ast 1 -aet 200 ";
	setAttr ".st" 6;
createNode polyCube -n "polyCube2";
	rename -uid "C839C1BB-4D18-E10A-E2F5-80945F2E8771";
	setAttr ".w" 2.5537403220558725;
	setAttr ".h" 0.46696251970438291;
	setAttr ".d" 3.0689384877618462;
	setAttr ".sw" 4;
	setAttr ".sd" 3;
	setAttr ".cuv" 4;
createNode polyBevel3 -n "polyBevel1";
	rename -uid "F08C317F-496B-F1B9-D6CD-C5A4524EEB84";
	setAttr ".uopa" yes;
	setAttr ".ics" -type "componentList" 2 "e[36]" "e[56]";
	setAttr ".ix" -type "matrix" 0.26838153480786253 0 0 0 0 1 0 0 0 0 0.88655233610516826 0
		 -3.1487928145058754 0.23348125985219145 -8.5140090179626107 1;
	setAttr ".ws" yes;
	setAttr ".oaf" yes;
	setAttr ".f" 0.8773006133312371;
	setAttr ".sg" 4;
	setAttr ".af" no;
	setAttr ".at" 180;
	setAttr ".fn" yes;
	setAttr ".mv" yes;
	setAttr ".mvt" 0.0001;
	setAttr ".ma" 180;
createNode polyTweak -n "polyTweak2";
	rename -uid "E5B00BD1-4897-AA38-C39A-92BC6CCE0E7D";
	setAttr ".uopa" yes;
	setAttr -s 20 ".tk";
	setAttr ".tk[0]" -type "float3" 0.30983505 0 0 ;
	setAttr ".tk[3]" -type "float3" 0.13693032 -0.001647599 0.0066857128 ;
	setAttr ".tk[4]" -type "float3" 1.5869309 -0.001647599 -0.663822 ;
	setAttr ".tk[5]" -type "float3" 0.30983505 0 0 ;
	setAttr ".tk[8]" -type "float3" 0.13693032 0.001647599 0.0066857128 ;
	setAttr ".tk[9]" -type "float3" 1.5869309 0.001647599 -0.663822 ;
	setAttr ".tk[10]" -type "float3" 0.30983505 0 0 ;
	setAttr ".tk[14]" -type "float3" 3.2493277 0.001647599 -0.15269351 ;
	setAttr ".tk[15]" -type "float3" 0.30983505 0 0 ;
	setAttr ".tk[19]" -type "float3" 3.2493277 0.001647599 0.14440846 ;
	setAttr ".tk[20]" -type "float3" 0.30983505 0 0 ;
	setAttr ".tk[23]" -type "float3" 0.13918294 0 0 ;
	setAttr ".tk[24]" -type "float3" 1.5948764 0 0.66516715 ;
	setAttr ".tk[25]" -type "float3" 0.30983505 0 0 ;
	setAttr ".tk[28]" -type "float3" 0.13918294 0 0 ;
	setAttr ".tk[29]" -type "float3" 1.5948764 0 0.66516715 ;
	setAttr ".tk[30]" -type "float3" 0.30983505 0 0 ;
	setAttr ".tk[34]" -type "float3" 3.2493277 -0.001647599 0.14440846 ;
	setAttr ".tk[35]" -type "float3" 0.30983505 0 0 ;
	setAttr ".tk[39]" -type "float3" 3.2493277 -0.001647599 -0.15269351 ;
select -ne :time1;
	setAttr ".o" 1;
	setAttr ".unw" 1;
select -ne :hardwareRenderingGlobals;
	setAttr ".otfna" -type "stringArray" 22 "NURBS Curves" "NURBS Surfaces" "Polygons" "Subdiv Surface" "Particles" "Particle Instance" "Fluids" "Strokes" "Image Planes" "UI" "Lights" "Cameras" "Locators" "Joints" "IK Handles" "Deformers" "Motion Trails" "Components" "Hair Systems" "Follicles" "Misc. UI" "Ornaments"  ;
	setAttr ".otfva" -type "Int32Array" 22 0 1 1 1 1 1
		 1 1 1 0 0 0 0 0 0 0 0 0
		 0 0 0 0 ;
	setAttr ".fprt" yes;
select -ne :renderPartition;
	setAttr -s 2 ".st";
select -ne :renderGlobalsList1;
select -ne :defaultShaderList1;
	setAttr -s 4 ".s";
select -ne :postProcessList1;
	setAttr -s 2 ".p";
select -ne :defaultRenderingList1;
select -ne :initialShadingGroup;
	setAttr -s 10 ".dsm";
	setAttr ".ro" yes;
select -ne :initialParticleSE;
	setAttr ".ro" yes;
select -ne :defaultResolution;
	setAttr ".pa" 1;
select -ne :hardwareRenderGlobals;
	setAttr ".ctrs" 256;
	setAttr ".btrs" 512;
connectAttr "polyCube1.out" "pCubeShape1.i";
connectAttr "polySubdFace2.out" "pCubeShape4.i";
connectAttr "polySubdFace5.out" "pCubeShape6.i";
connectAttr "polyCylinder1.out" "pCylinderShape1.i";
connectAttr "polyBevel1.out" "pCubeShape9.i";
relationship "link" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "link" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialShadingGroup.message" ":defaultLightSet.message";
relationship "shadowLink" ":lightLinker1" ":initialParticleSE.message" ":defaultLightSet.message";
connectAttr "layerManager.dli[0]" "defaultLayer.id";
connectAttr "renderLayerManager.rlmi[0]" "defaultRenderLayer.rlid";
connectAttr "|pCube4|polySurfaceShape1.o" "polySubdFace1.ip";
connectAttr "polySubdFace1.out" "createColorSet1.ig";
connectAttr "polyTweak1.out" "polySubdFace2.ip";
connectAttr "createColorSet1.og" "polyTweak1.ip";
connectAttr "polySurfaceShape2.o" "polySubdFace3.ip";
connectAttr "polySubdFace3.out" "polySubdFace4.ip";
connectAttr "polySubdFace4.out" "polySubdFace5.ip";
connectAttr "polyTweak2.out" "polyBevel1.ip";
connectAttr "pCubeShape9.wm" "polyBevel1.mp";
connectAttr "polyCube2.out" "polyTweak2.ip";
connectAttr "defaultRenderLayer.msg" ":defaultRenderingList1.r" -na;
connectAttr "pCubeShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape2.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape3.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape4.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape5.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape6.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCylinderShape1.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape7.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape8.iog" ":initialShadingGroup.dsm" -na;
connectAttr "pCubeShape9.iog" ":initialShadingGroup.dsm" -na;
// End of Bedding.ma
