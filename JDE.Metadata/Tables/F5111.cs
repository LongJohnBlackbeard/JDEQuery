using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5111 - .
/// </summary>
public class F5111 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FDMCU.
        /// </summary>
        public const string FDMCU = "FDMCU";

        /// <summary>
        /// FDFORVER.
        /// </summary>
        public const string FDFORVER = "FDFORVER";

        /// <summary>
        /// FDAID.
        /// </summary>
        public const string FDAID = "FDAID";

        /// <summary>
        /// FDOBJ.
        /// </summary>
        public const string FDOBJ = "FDOBJ";

        /// <summary>
        /// FDSUB.
        /// </summary>
        public const string FDSUB = "FDSUB";

        /// <summary>
        /// FDATST.
        /// </summary>
        public const string FDATST = "FDATST";

        /// <summary>
        /// FDPNFN.
        /// </summary>
        public const string FDPNFN = "FDPNFN";

        /// <summary>
        /// FDGLDTE.
        /// </summary>
        public const string FDGLDTE = "FDGLDTE";

        /// <summary>
        /// FDDATPER.
        /// </summary>
        public const string FDDATPER = "FDDATPER";

        /// <summary>
        /// FDLDA.
        /// </summary>
        public const string FDLDA = "FDLDA";

        /// <summary>
        /// FDHEADDESC.
        /// </summary>
        public const string FDHEADDESC = "FDHEADDESC";

        /// <summary>
        /// FDACCTDESC.
        /// </summary>
        public const string FDACCTDESC = "FDACCTDESC";

        /// <summary>
        /// FDDAYSREM.
        /// </summary>
        public const string FDDAYSREM = "FDDAYSREM";

        /// <summary>
        /// FDREVBUD.
        /// </summary>
        public const string FDREVBUD = "FDREVBUD";

        /// <summary>
        /// FDBORG.
        /// </summary>
        public const string FDBORG = "FDBORG";

        /// <summary>
        /// FDITDACTUAL.
        /// </summary>
        public const string FDITDACTUAL = "FDITDACTUAL";

        /// <summary>
        /// FDDAILYRATE.
        /// </summary>
        public const string FDDAILYRATE = "FDDAILYRATE";

        /// <summary>
        /// FDETC.
        /// </summary>
        public const string FDETC = "FDETC";

        /// <summary>
        /// FDPFAA.
        /// </summary>
        public const string FDPFAA = "FDPFAA";

        /// <summary>
        /// FDCURACT.
        /// </summary>
        public const string FDCURACT = "FDCURACT";

        /// <summary>
        /// FDFCRMAA.
        /// </summary>
        public const string FDFCRMAA = "FDFCRMAA";

        /// <summary>
        /// FDFCAMT01.
        /// </summary>
        public const string FDFCAMT01 = "FDFCAMT01";

        /// <summary>
        /// FDFCDAYS01.
        /// </summary>
        public const string FDFCDAYS01 = "FDFCDAYS01";

        /// <summary>
        /// FDFCAMT02.
        /// </summary>
        public const string FDFCAMT02 = "FDFCAMT02";

        /// <summary>
        /// FDFCDAYS02.
        /// </summary>
        public const string FDFCDAYS02 = "FDFCDAYS02";

        /// <summary>
        /// FDFCAMT03.
        /// </summary>
        public const string FDFCAMT03 = "FDFCAMT03";

        /// <summary>
        /// FDFCDAYS03.
        /// </summary>
        public const string FDFCDAYS03 = "FDFCDAYS03";

        /// <summary>
        /// FDFCAMT04.
        /// </summary>
        public const string FDFCAMT04 = "FDFCAMT04";

        /// <summary>
        /// FDFCDAYS04.
        /// </summary>
        public const string FDFCDAYS04 = "FDFCDAYS04";

        /// <summary>
        /// FDFCAMT05.
        /// </summary>
        public const string FDFCAMT05 = "FDFCAMT05";

        /// <summary>
        /// FDFCDAYS05.
        /// </summary>
        public const string FDFCDAYS05 = "FDFCDAYS05";

        /// <summary>
        /// FDFCAMT06.
        /// </summary>
        public const string FDFCAMT06 = "FDFCAMT06";

        /// <summary>
        /// FDFCDAYS06.
        /// </summary>
        public const string FDFCDAYS06 = "FDFCDAYS06";

        /// <summary>
        /// FDFCAMT07.
        /// </summary>
        public const string FDFCAMT07 = "FDFCAMT07";

        /// <summary>
        /// FDFCDAYS07.
        /// </summary>
        public const string FDFCDAYS07 = "FDFCDAYS07";

        /// <summary>
        /// FDFCAMT08.
        /// </summary>
        public const string FDFCAMT08 = "FDFCAMT08";

        /// <summary>
        /// FDFCDAYS08.
        /// </summary>
        public const string FDFCDAYS08 = "FDFCDAYS08";

        /// <summary>
        /// FDFCAMT09.
        /// </summary>
        public const string FDFCAMT09 = "FDFCAMT09";

        /// <summary>
        /// FDFCDAYS09.
        /// </summary>
        public const string FDFCDAYS09 = "FDFCDAYS09";

        /// <summary>
        /// FDFCAMT10.
        /// </summary>
        public const string FDFCAMT10 = "FDFCAMT10";

        /// <summary>
        /// FDFCDAYS10.
        /// </summary>
        public const string FDFCDAYS10 = "FDFCDAYS10";

        /// <summary>
        /// FDFCAMT11.
        /// </summary>
        public const string FDFCAMT11 = "FDFCAMT11";

        /// <summary>
        /// FDFCDAYS11.
        /// </summary>
        public const string FDFCDAYS11 = "FDFCDAYS11";

        /// <summary>
        /// FDFCAMT12.
        /// </summary>
        public const string FDFCAMT12 = "FDFCAMT12";

        /// <summary>
        /// FDFCDAYS12.
        /// </summary>
        public const string FDFCDAYS12 = "FDFCDAYS12";

        /// <summary>
        /// FDFCAMT13.
        /// </summary>
        public const string FDFCAMT13 = "FDFCAMT13";

        /// <summary>
        /// FDFCDAYS13.
        /// </summary>
        public const string FDFCDAYS13 = "FDFCDAYS13";

        /// <summary>
        /// FDFCAMT14.
        /// </summary>
        public const string FDFCAMT14 = "FDFCAMT14";

        /// <summary>
        /// FDFCDAYS14.
        /// </summary>
        public const string FDFCDAYS14 = "FDFCDAYS14";

        /// <summary>
        /// FDFCAMT15.
        /// </summary>
        public const string FDFCAMT15 = "FDFCAMT15";

        /// <summary>
        /// FDFCDAYS15.
        /// </summary>
        public const string FDFCDAYS15 = "FDFCDAYS15";

        /// <summary>
        /// FDFCAMT16.
        /// </summary>
        public const string FDFCAMT16 = "FDFCAMT16";

        /// <summary>
        /// FDFCDAYS16.
        /// </summary>
        public const string FDFCDAYS16 = "FDFCDAYS16";

        /// <summary>
        /// FDFCAMT17.
        /// </summary>
        public const string FDFCAMT17 = "FDFCAMT17";

        /// <summary>
        /// FDFCDAYS17.
        /// </summary>
        public const string FDFCDAYS17 = "FDFCDAYS17";

        /// <summary>
        /// FDFCAMT18.
        /// </summary>
        public const string FDFCAMT18 = "FDFCAMT18";

        /// <summary>
        /// FDFCDAYS18.
        /// </summary>
        public const string FDFCDAYS18 = "FDFCDAYS18";

        /// <summary>
        /// FDFCAMT19.
        /// </summary>
        public const string FDFCAMT19 = "FDFCAMT19";

        /// <summary>
        /// FDFCDAYS19.
        /// </summary>
        public const string FDFCDAYS19 = "FDFCDAYS19";

        /// <summary>
        /// FDFCAMT20.
        /// </summary>
        public const string FDFCAMT20 = "FDFCAMT20";

        /// <summary>
        /// FDFCDAYS20.
        /// </summary>
        public const string FDFCDAYS20 = "FDFCDAYS20";

        /// <summary>
        /// FDFCAMT21.
        /// </summary>
        public const string FDFCAMT21 = "FDFCAMT21";

        /// <summary>
        /// FDFCDAYS21.
        /// </summary>
        public const string FDFCDAYS21 = "FDFCDAYS21";

        /// <summary>
        /// FDFCAMT22.
        /// </summary>
        public const string FDFCAMT22 = "FDFCAMT22";

        /// <summary>
        /// FDFCDAYS22.
        /// </summary>
        public const string FDFCDAYS22 = "FDFCDAYS22";

        /// <summary>
        /// FDFCAMT23.
        /// </summary>
        public const string FDFCAMT23 = "FDFCAMT23";

        /// <summary>
        /// FDFCDAYS23.
        /// </summary>
        public const string FDFCDAYS23 = "FDFCDAYS23";

        /// <summary>
        /// FDFCAMT24.
        /// </summary>
        public const string FDFCAMT24 = "FDFCAMT24";

        /// <summary>
        /// FDFCDAYS24.
        /// </summary>
        public const string FDFCDAYS24 = "FDFCDAYS24";

        /// <summary>
        /// FDFCAMT25.
        /// </summary>
        public const string FDFCAMT25 = "FDFCAMT25";

        /// <summary>
        /// FDFCDAYS25.
        /// </summary>
        public const string FDFCDAYS25 = "FDFCDAYS25";

        /// <summary>
        /// FDFCAMT26.
        /// </summary>
        public const string FDFCAMT26 = "FDFCAMT26";

        /// <summary>
        /// FDFCDAYS26.
        /// </summary>
        public const string FDFCDAYS26 = "FDFCDAYS26";

        /// <summary>
        /// FDFCAMT27.
        /// </summary>
        public const string FDFCAMT27 = "FDFCAMT27";

        /// <summary>
        /// FDFCDAYS27.
        /// </summary>
        public const string FDFCDAYS27 = "FDFCDAYS27";

        /// <summary>
        /// FDFCAMT28.
        /// </summary>
        public const string FDFCAMT28 = "FDFCAMT28";

        /// <summary>
        /// FDFCDAYS28.
        /// </summary>
        public const string FDFCDAYS28 = "FDFCDAYS28";

        /// <summary>
        /// FDFCAMT29.
        /// </summary>
        public const string FDFCAMT29 = "FDFCAMT29";

        /// <summary>
        /// FDFCDAYS29.
        /// </summary>
        public const string FDFCDAYS29 = "FDFCDAYS29";

        /// <summary>
        /// FDFCAMT30.
        /// </summary>
        public const string FDFCAMT30 = "FDFCAMT30";

        /// <summary>
        /// FDFCDAYS30.
        /// </summary>
        public const string FDFCDAYS30 = "FDFCDAYS30";

        /// <summary>
        /// FDFCAMT31.
        /// </summary>
        public const string FDFCAMT31 = "FDFCAMT31";

        /// <summary>
        /// FDFCDAYS31.
        /// </summary>
        public const string FDFCDAYS31 = "FDFCDAYS31";

        /// <summary>
        /// FDFCAMT32.
        /// </summary>
        public const string FDFCAMT32 = "FDFCAMT32";

        /// <summary>
        /// FDFCDAYS32.
        /// </summary>
        public const string FDFCDAYS32 = "FDFCDAYS32";

        /// <summary>
        /// FDFCAMT33.
        /// </summary>
        public const string FDFCAMT33 = "FDFCAMT33";

        /// <summary>
        /// FDFCDAYS33.
        /// </summary>
        public const string FDFCDAYS33 = "FDFCDAYS33";

        /// <summary>
        /// FDFCAMT34.
        /// </summary>
        public const string FDFCAMT34 = "FDFCAMT34";

        /// <summary>
        /// FDFCDAYS34.
        /// </summary>
        public const string FDFCDAYS34 = "FDFCDAYS34";

        /// <summary>
        /// FDFCAMT35.
        /// </summary>
        public const string FDFCAMT35 = "FDFCAMT35";

        /// <summary>
        /// FDFCDAYS35.
        /// </summary>
        public const string FDFCDAYS35 = "FDFCDAYS35";

        /// <summary>
        /// FDFCAMT36.
        /// </summary>
        public const string FDFCAMT36 = "FDFCAMT36";

        /// <summary>
        /// FDFCDAYS36.
        /// </summary>
        public const string FDFCDAYS36 = "FDFCDAYS36";

        /// <summary>
        /// FDFCAMT37.
        /// </summary>
        public const string FDFCAMT37 = "FDFCAMT37";

        /// <summary>
        /// FDFCDAYS37.
        /// </summary>
        public const string FDFCDAYS37 = "FDFCDAYS37";

        /// <summary>
        /// FDFCAMT38.
        /// </summary>
        public const string FDFCAMT38 = "FDFCAMT38";

        /// <summary>
        /// FDFCDAYS38.
        /// </summary>
        public const string FDFCDAYS38 = "FDFCDAYS38";

        /// <summary>
        /// FDFCAMT39.
        /// </summary>
        public const string FDFCAMT39 = "FDFCAMT39";

        /// <summary>
        /// FDFCDAYS39.
        /// </summary>
        public const string FDFCDAYS39 = "FDFCDAYS39";

        /// <summary>
        /// FDFCAMT40.
        /// </summary>
        public const string FDFCAMT40 = "FDFCAMT40";

        /// <summary>
        /// FDFCDAYS40.
        /// </summary>
        public const string FDFCDAYS40 = "FDFCDAYS40";

        /// <summary>
        /// FDFCAMT41.
        /// </summary>
        public const string FDFCAMT41 = "FDFCAMT41";

        /// <summary>
        /// FDFCDAYS41.
        /// </summary>
        public const string FDFCDAYS41 = "FDFCDAYS41";

        /// <summary>
        /// FDFCAMT42.
        /// </summary>
        public const string FDFCAMT42 = "FDFCAMT42";

        /// <summary>
        /// FDFCDAYS42.
        /// </summary>
        public const string FDFCDAYS42 = "FDFCDAYS42";

        /// <summary>
        /// FDFCAMT43.
        /// </summary>
        public const string FDFCAMT43 = "FDFCAMT43";

        /// <summary>
        /// FDFCDAYS43.
        /// </summary>
        public const string FDFCDAYS43 = "FDFCDAYS43";

        /// <summary>
        /// FDFCAMT44.
        /// </summary>
        public const string FDFCAMT44 = "FDFCAMT44";

        /// <summary>
        /// FDFCDAYS44.
        /// </summary>
        public const string FDFCDAYS44 = "FDFCDAYS44";

        /// <summary>
        /// FDFCAMT45.
        /// </summary>
        public const string FDFCAMT45 = "FDFCAMT45";

        /// <summary>
        /// FDFCDAYS45.
        /// </summary>
        public const string FDFCDAYS45 = "FDFCDAYS45";

        /// <summary>
        /// FDFCAMT46.
        /// </summary>
        public const string FDFCAMT46 = "FDFCAMT46";

        /// <summary>
        /// FDFCDAYS46.
        /// </summary>
        public const string FDFCDAYS46 = "FDFCDAYS46";

        /// <summary>
        /// FDFCAMT47.
        /// </summary>
        public const string FDFCAMT47 = "FDFCAMT47";

        /// <summary>
        /// FDFCDAYS47.
        /// </summary>
        public const string FDFCDAYS47 = "FDFCDAYS47";

        /// <summary>
        /// FDFCAMT48.
        /// </summary>
        public const string FDFCAMT48 = "FDFCAMT48";

        /// <summary>
        /// FDFCDAYS48.
        /// </summary>
        public const string FDFCDAYS48 = "FDFCDAYS48";

        /// <summary>
        /// FDCPYFRMVER.
        /// </summary>
        public const string FDCPYFRMVER = "FDCPYFRMVER";

        /// <summary>
        /// FDUSER.
        /// </summary>
        public const string FDUSER = "FDUSER";

        /// <summary>
        /// FDPID.
        /// </summary>
        public const string FDPID = "FDPID";

        /// <summary>
        /// FDUPMJ.
        /// </summary>
        public const string FDUPMJ = "FDUPMJ";

        /// <summary>
        /// FDUPMT.
        /// </summary>
        public const string FDUPMT = "FDUPMT";

        /// <summary>
        /// FDJOBN.
        /// </summary>
        public const string FDJOBN = "FDJOBN";

        /// <summary>
        /// FDRECTYPE1.
        /// </summary>
        public const string FDRECTYPE1 = "FDRECTYPE1";

        /// <summary>
        /// FDCCT.
        /// </summary>
        public const string FDCCT = "FDCCT";

        /// <summary>
        /// FDSBL.
        /// </summary>
        public const string FDSBL = "FDSBL";

        /// <summary>
        /// FDSBLT.
        /// </summary>
        public const string FDSBLT = "FDSBLT";
    }

    /// <inheritdoc />
    public override string TableName => "F5111";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FDMCU", "FDMCU", JdeDataType.String, 24, true, true),
        new JdeField("FDFORVER", "FDFORVER", JdeDataType.String, 20, true, true),
        new JdeField("FDAID", "FDAID", JdeDataType.String, 16, true, true),
        new JdeField("FDOBJ", "FDOBJ", JdeDataType.String, 12),
        new JdeField("FDSUB", "FDSUB", JdeDataType.String, 16),
        new JdeField("FDATST", "FDATST", JdeDataType.Numeric),
        new JdeField("FDPNFN", "FDPNFN", JdeDataType.Numeric),
        new JdeField("FDGLDTE", "FDGLDTE", JdeDataType.Numeric),
        new JdeField("FDDATPER", "FDDATPER", JdeDataType.String, 2),
        new JdeField("FDLDA", "FDLDA", JdeDataType.String, 2),
        new JdeField("FDHEADDESC", "FDHEADDESC", JdeDataType.String, 60),
        new JdeField("FDACCTDESC", "FDACCTDESC", JdeDataType.String, 60),
        new JdeField("FDDAYSREM", "FDDAYSREM", JdeDataType.Numeric),
        new JdeField("FDREVBUD", "FDREVBUD", JdeDataType.Numeric),
        new JdeField("FDBORG", "FDBORG", JdeDataType.Numeric),
        new JdeField("FDITDACTUAL", "FDITDACTUAL", JdeDataType.Numeric),
        new JdeField("FDDAILYRATE", "FDDAILYRATE", JdeDataType.Numeric),
        new JdeField("FDETC", "FDETC", JdeDataType.Numeric),
        new JdeField("FDPFAA", "FDPFAA", JdeDataType.Numeric),
        new JdeField("FDCURACT", "FDCURACT", JdeDataType.Numeric),
        new JdeField("FDFCRMAA", "FDFCRMAA", JdeDataType.Numeric),
        new JdeField("FDFCAMT01", "FDFCAMT01", JdeDataType.Numeric),
        new JdeField("FDFCDAYS01", "FDFCDAYS01", JdeDataType.Numeric),
        new JdeField("FDFCAMT02", "FDFCAMT02", JdeDataType.Numeric),
        new JdeField("FDFCDAYS02", "FDFCDAYS02", JdeDataType.Numeric),
        new JdeField("FDFCAMT03", "FDFCAMT03", JdeDataType.Numeric),
        new JdeField("FDFCDAYS03", "FDFCDAYS03", JdeDataType.Numeric),
        new JdeField("FDFCAMT04", "FDFCAMT04", JdeDataType.Numeric),
        new JdeField("FDFCDAYS04", "FDFCDAYS04", JdeDataType.Numeric),
        new JdeField("FDFCAMT05", "FDFCAMT05", JdeDataType.Numeric),
        new JdeField("FDFCDAYS05", "FDFCDAYS05", JdeDataType.Numeric),
        new JdeField("FDFCAMT06", "FDFCAMT06", JdeDataType.Numeric),
        new JdeField("FDFCDAYS06", "FDFCDAYS06", JdeDataType.Numeric),
        new JdeField("FDFCAMT07", "FDFCAMT07", JdeDataType.Numeric),
        new JdeField("FDFCDAYS07", "FDFCDAYS07", JdeDataType.Numeric),
        new JdeField("FDFCAMT08", "FDFCAMT08", JdeDataType.Numeric),
        new JdeField("FDFCDAYS08", "FDFCDAYS08", JdeDataType.Numeric),
        new JdeField("FDFCAMT09", "FDFCAMT09", JdeDataType.Numeric),
        new JdeField("FDFCDAYS09", "FDFCDAYS09", JdeDataType.Numeric),
        new JdeField("FDFCAMT10", "FDFCAMT10", JdeDataType.Numeric),
        new JdeField("FDFCDAYS10", "FDFCDAYS10", JdeDataType.Numeric),
        new JdeField("FDFCAMT11", "FDFCAMT11", JdeDataType.Numeric),
        new JdeField("FDFCDAYS11", "FDFCDAYS11", JdeDataType.Numeric),
        new JdeField("FDFCAMT12", "FDFCAMT12", JdeDataType.Numeric),
        new JdeField("FDFCDAYS12", "FDFCDAYS12", JdeDataType.Numeric),
        new JdeField("FDFCAMT13", "FDFCAMT13", JdeDataType.Numeric),
        new JdeField("FDFCDAYS13", "FDFCDAYS13", JdeDataType.Numeric),
        new JdeField("FDFCAMT14", "FDFCAMT14", JdeDataType.Numeric),
        new JdeField("FDFCDAYS14", "FDFCDAYS14", JdeDataType.Numeric),
        new JdeField("FDFCAMT15", "FDFCAMT15", JdeDataType.Numeric),
        new JdeField("FDFCDAYS15", "FDFCDAYS15", JdeDataType.Numeric),
        new JdeField("FDFCAMT16", "FDFCAMT16", JdeDataType.Numeric),
        new JdeField("FDFCDAYS16", "FDFCDAYS16", JdeDataType.Numeric),
        new JdeField("FDFCAMT17", "FDFCAMT17", JdeDataType.Numeric),
        new JdeField("FDFCDAYS17", "FDFCDAYS17", JdeDataType.Numeric),
        new JdeField("FDFCAMT18", "FDFCAMT18", JdeDataType.Numeric),
        new JdeField("FDFCDAYS18", "FDFCDAYS18", JdeDataType.Numeric),
        new JdeField("FDFCAMT19", "FDFCAMT19", JdeDataType.Numeric),
        new JdeField("FDFCDAYS19", "FDFCDAYS19", JdeDataType.Numeric),
        new JdeField("FDFCAMT20", "FDFCAMT20", JdeDataType.Numeric),
        new JdeField("FDFCDAYS20", "FDFCDAYS20", JdeDataType.Numeric),
        new JdeField("FDFCAMT21", "FDFCAMT21", JdeDataType.Numeric),
        new JdeField("FDFCDAYS21", "FDFCDAYS21", JdeDataType.Numeric),
        new JdeField("FDFCAMT22", "FDFCAMT22", JdeDataType.Numeric),
        new JdeField("FDFCDAYS22", "FDFCDAYS22", JdeDataType.Numeric),
        new JdeField("FDFCAMT23", "FDFCAMT23", JdeDataType.Numeric),
        new JdeField("FDFCDAYS23", "FDFCDAYS23", JdeDataType.Numeric),
        new JdeField("FDFCAMT24", "FDFCAMT24", JdeDataType.Numeric),
        new JdeField("FDFCDAYS24", "FDFCDAYS24", JdeDataType.Numeric),
        new JdeField("FDFCAMT25", "FDFCAMT25", JdeDataType.Numeric),
        new JdeField("FDFCDAYS25", "FDFCDAYS25", JdeDataType.Numeric),
        new JdeField("FDFCAMT26", "FDFCAMT26", JdeDataType.Numeric),
        new JdeField("FDFCDAYS26", "FDFCDAYS26", JdeDataType.Numeric),
        new JdeField("FDFCAMT27", "FDFCAMT27", JdeDataType.Numeric),
        new JdeField("FDFCDAYS27", "FDFCDAYS27", JdeDataType.Numeric),
        new JdeField("FDFCAMT28", "FDFCAMT28", JdeDataType.Numeric),
        new JdeField("FDFCDAYS28", "FDFCDAYS28", JdeDataType.Numeric),
        new JdeField("FDFCAMT29", "FDFCAMT29", JdeDataType.Numeric),
        new JdeField("FDFCDAYS29", "FDFCDAYS29", JdeDataType.Numeric),
        new JdeField("FDFCAMT30", "FDFCAMT30", JdeDataType.Numeric),
        new JdeField("FDFCDAYS30", "FDFCDAYS30", JdeDataType.Numeric),
        new JdeField("FDFCAMT31", "FDFCAMT31", JdeDataType.Numeric),
        new JdeField("FDFCDAYS31", "FDFCDAYS31", JdeDataType.Numeric),
        new JdeField("FDFCAMT32", "FDFCAMT32", JdeDataType.Numeric),
        new JdeField("FDFCDAYS32", "FDFCDAYS32", JdeDataType.Numeric),
        new JdeField("FDFCAMT33", "FDFCAMT33", JdeDataType.Numeric),
        new JdeField("FDFCDAYS33", "FDFCDAYS33", JdeDataType.Numeric),
        new JdeField("FDFCAMT34", "FDFCAMT34", JdeDataType.Numeric),
        new JdeField("FDFCDAYS34", "FDFCDAYS34", JdeDataType.Numeric),
        new JdeField("FDFCAMT35", "FDFCAMT35", JdeDataType.Numeric),
        new JdeField("FDFCDAYS35", "FDFCDAYS35", JdeDataType.Numeric),
        new JdeField("FDFCAMT36", "FDFCAMT36", JdeDataType.Numeric),
        new JdeField("FDFCDAYS36", "FDFCDAYS36", JdeDataType.Numeric),
        new JdeField("FDFCAMT37", "FDFCAMT37", JdeDataType.Numeric),
        new JdeField("FDFCDAYS37", "FDFCDAYS37", JdeDataType.Numeric),
        new JdeField("FDFCAMT38", "FDFCAMT38", JdeDataType.Numeric),
        new JdeField("FDFCDAYS38", "FDFCDAYS38", JdeDataType.Numeric),
        new JdeField("FDFCAMT39", "FDFCAMT39", JdeDataType.Numeric),
        new JdeField("FDFCDAYS39", "FDFCDAYS39", JdeDataType.Numeric),
        new JdeField("FDFCAMT40", "FDFCAMT40", JdeDataType.Numeric),
        new JdeField("FDFCDAYS40", "FDFCDAYS40", JdeDataType.Numeric),
        new JdeField("FDFCAMT41", "FDFCAMT41", JdeDataType.Numeric),
        new JdeField("FDFCDAYS41", "FDFCDAYS41", JdeDataType.Numeric),
        new JdeField("FDFCAMT42", "FDFCAMT42", JdeDataType.Numeric),
        new JdeField("FDFCDAYS42", "FDFCDAYS42", JdeDataType.Numeric),
        new JdeField("FDFCAMT43", "FDFCAMT43", JdeDataType.Numeric),
        new JdeField("FDFCDAYS43", "FDFCDAYS43", JdeDataType.Numeric),
        new JdeField("FDFCAMT44", "FDFCAMT44", JdeDataType.Numeric),
        new JdeField("FDFCDAYS44", "FDFCDAYS44", JdeDataType.Numeric),
        new JdeField("FDFCAMT45", "FDFCAMT45", JdeDataType.Numeric),
        new JdeField("FDFCDAYS45", "FDFCDAYS45", JdeDataType.Numeric),
        new JdeField("FDFCAMT46", "FDFCAMT46", JdeDataType.Numeric),
        new JdeField("FDFCDAYS46", "FDFCDAYS46", JdeDataType.Numeric),
        new JdeField("FDFCAMT47", "FDFCAMT47", JdeDataType.Numeric),
        new JdeField("FDFCDAYS47", "FDFCDAYS47", JdeDataType.Numeric),
        new JdeField("FDFCAMT48", "FDFCAMT48", JdeDataType.Numeric),
        new JdeField("FDFCDAYS48", "FDFCDAYS48", JdeDataType.Numeric),
        new JdeField("FDCPYFRMVER", "FDCPYFRMVER", JdeDataType.String, 20),
        new JdeField("FDUSER", "FDUSER", JdeDataType.String, 20),
        new JdeField("FDPID", "FDPID", JdeDataType.String, 20),
        new JdeField("FDUPMJ", "FDUPMJ", JdeDataType.Numeric),
        new JdeField("FDUPMT", "FDUPMT", JdeDataType.Numeric),
        new JdeField("FDJOBN", "FDJOBN", JdeDataType.String, 20),
        new JdeField("FDRECTYPE1", "FDRECTYPE1", JdeDataType.String, 2),
        new JdeField("FDCCT", "FDCCT", JdeDataType.String, 2),
        new JdeField("FDSBL", "FDSBL", JdeDataType.String, 16),
        new JdeField("FDSBLT", "FDSBLT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5111_0", "Primary Key on FDMCU, FDFORVER, FDAID", new[] { "FDMCU", "FDFORVER", "FDAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5111_2", "Index on FDMCU, FDFORVER", new[] { "FDMCU", "FDFORVER" })
    };
}
