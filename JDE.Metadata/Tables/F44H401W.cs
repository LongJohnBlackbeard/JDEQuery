using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H401W - .
/// </summary>
public class F44H401W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OWJOBS.
        /// </summary>
        public const string OWJOBS = "OWJOBS";

        /// <summary>
        /// OWHBAREA.
        /// </summary>
        public const string OWHBAREA = "OWHBAREA";

        /// <summary>
        /// OWHBMCUS.
        /// </summary>
        public const string OWHBMCUS = "OWHBMCUS";

        /// <summary>
        /// OWCPHASE.
        /// </summary>
        public const string OWCPHASE = "OWCPHASE";

        /// <summary>
        /// OWHBPLAN.
        /// </summary>
        public const string OWHBPLAN = "OWHBPLAN";

        /// <summary>
        /// OWHBELEV.
        /// </summary>
        public const string OWHBELEV = "OWHBELEV";

        /// <summary>
        /// OWOPTION.
        /// </summary>
        public const string OWOPTION = "OWOPTION";

        /// <summary>
        /// OWDL01.
        /// </summary>
        public const string OWDL01 = "OWDL01";

        /// <summary>
        /// OWDL02.
        /// </summary>
        public const string OWDL02 = "OWDL02";

        /// <summary>
        /// OWDL03.
        /// </summary>
        public const string OWDL03 = "OWDL03";

        /// <summary>
        /// OWDL04.
        /// </summary>
        public const string OWDL04 = "OWDL04";

        /// <summary>
        /// OWDL05.
        /// </summary>
        public const string OWDL05 = "OWDL05";

        /// <summary>
        /// OWDL06.
        /// </summary>
        public const string OWDL06 = "OWDL06";

        /// <summary>
        /// OWHBOAREA.
        /// </summary>
        public const string OWHBOAREA = "OWHBOAREA";

        /// <summary>
        /// OWHBOMCUS.
        /// </summary>
        public const string OWHBOMCUS = "OWHBOMCUS";

        /// <summary>
        /// OWHBOPLAN.
        /// </summary>
        public const string OWHBOPLAN = "OWHBOPLAN";

        /// <summary>
        /// OWOCPHASE.
        /// </summary>
        public const string OWOCPHASE = "OWOCPHASE";

        /// <summary>
        /// OWHBOELEV.
        /// </summary>
        public const string OWHBOELEV = "OWHBOELEV";

        /// <summary>
        /// OWOPTYP.
        /// </summary>
        public const string OWOPTYP = "OWOPTYP";

        /// <summary>
        /// OWOPKG.
        /// </summary>
        public const string OWOPKG = "OWOPKG";

        /// <summary>
        /// OWOPKGC.
        /// </summary>
        public const string OWOPKGC = "OWOPKGC";

        /// <summary>
        /// OWOCSTM.
        /// </summary>
        public const string OWOCSTM = "OWOCSTM";

        /// <summary>
        /// OWHBLOT.
        /// </summary>
        public const string OWHBLOT = "OWHBLOT";

        /// <summary>
        /// OWDPTP.
        /// </summary>
        public const string OWDPTP = "OWDPTP";

        /// <summary>
        /// OWCSPR.
        /// </summary>
        public const string OWCSPR = "OWCSPR";

        /// <summary>
        /// OWSPJ.
        /// </summary>
        public const string OWSPJ = "OWSPJ";

        /// <summary>
        /// OWEXDE.
        /// </summary>
        public const string OWEXDE = "OWEXDE";

        /// <summary>
        /// OWHGPP.
        /// </summary>
        public const string OWHGPP = "OWHGPP";

        /// <summary>
        /// OWPSPR.
        /// </summary>
        public const string OWPSPR = "OWPSPR";

        /// <summary>
        /// OWAMTO.
        /// </summary>
        public const string OWAMTO = "OWAMTO";

        /// <summary>
        /// OWSTRT.
        /// </summary>
        public const string OWSTRT = "OWSTRT";

        /// <summary>
        /// OWINACDTJ.
        /// </summary>
        public const string OWINACDTJ = "OWINACDTJ";

        /// <summary>
        /// OWPLNQ.
        /// </summary>
        public const string OWPLNQ = "OWPLNQ";

        /// <summary>
        /// OWOPM01.
        /// </summary>
        public const string OWOPM01 = "OWOPM01";

        /// <summary>
        /// OWOPM02.
        /// </summary>
        public const string OWOPM02 = "OWOPM02";

        /// <summary>
        /// OWOPM03.
        /// </summary>
        public const string OWOPM03 = "OWOPM03";

        /// <summary>
        /// OWOPM04.
        /// </summary>
        public const string OWOPM04 = "OWOPM04";

        /// <summary>
        /// OWOPM05.
        /// </summary>
        public const string OWOPM05 = "OWOPM05";

        /// <summary>
        /// OWOPM06.
        /// </summary>
        public const string OWOPM06 = "OWOPM06";

        /// <summary>
        /// OWOPM07.
        /// </summary>
        public const string OWOPM07 = "OWOPM07";

        /// <summary>
        /// OWOPM08.
        /// </summary>
        public const string OWOPM08 = "OWOPM08";

        /// <summary>
        /// OWOPM09.
        /// </summary>
        public const string OWOPM09 = "OWOPM09";

        /// <summary>
        /// OWOPM10.
        /// </summary>
        public const string OWOPM10 = "OWOPM10";

        /// <summary>
        /// OWOPM11.
        /// </summary>
        public const string OWOPM11 = "OWOPM11";

        /// <summary>
        /// OWOPM12.
        /// </summary>
        public const string OWOPM12 = "OWOPM12";

        /// <summary>
        /// OWOPM13.
        /// </summary>
        public const string OWOPM13 = "OWOPM13";

        /// <summary>
        /// OWOPM14.
        /// </summary>
        public const string OWOPM14 = "OWOPM14";

        /// <summary>
        /// OWOPM15.
        /// </summary>
        public const string OWOPM15 = "OWOPM15";

        /// <summary>
        /// OWOPM16.
        /// </summary>
        public const string OWOPM16 = "OWOPM16";

        /// <summary>
        /// OWOPM17.
        /// </summary>
        public const string OWOPM17 = "OWOPM17";

        /// <summary>
        /// OWOPM18.
        /// </summary>
        public const string OWOPM18 = "OWOPM18";

        /// <summary>
        /// OWOPM19.
        /// </summary>
        public const string OWOPM19 = "OWOPM19";

        /// <summary>
        /// OWOPM20.
        /// </summary>
        public const string OWOPM20 = "OWOPM20";

        /// <summary>
        /// OWOPSTAV.
        /// </summary>
        public const string OWOPSTAV = "OWOPSTAV";

        /// <summary>
        /// OWOPSTCO.
        /// </summary>
        public const string OWOPSTCO = "OWOPSTCO";

        /// <summary>
        /// OWOPLVL.
        /// </summary>
        public const string OWOPLVL = "OWOPLVL";

        /// <summary>
        /// OWHBST1.
        /// </summary>
        public const string OWHBST1 = "OWHBST1";

        /// <summary>
        /// OWHBST2.
        /// </summary>
        public const string OWHBST2 = "OWHBST2";

        /// <summary>
        /// OWHBST3.
        /// </summary>
        public const string OWHBST3 = "OWHBST3";

        /// <summary>
        /// OWHBST4.
        /// </summary>
        public const string OWHBST4 = "OWHBST4";

        /// <summary>
        /// OWHBST5.
        /// </summary>
        public const string OWHBST5 = "OWHBST5";

        /// <summary>
        /// OWUC01.
        /// </summary>
        public const string OWUC01 = "OWUC01";

        /// <summary>
        /// OWUC02.
        /// </summary>
        public const string OWUC02 = "OWUC02";

        /// <summary>
        /// OWUC03.
        /// </summary>
        public const string OWUC03 = "OWUC03";

        /// <summary>
        /// OWUSD1.
        /// </summary>
        public const string OWUSD1 = "OWUSD1";

        /// <summary>
        /// OWUSD2.
        /// </summary>
        public const string OWUSD2 = "OWUSD2";

        /// <summary>
        /// OWUSD3.
        /// </summary>
        public const string OWUSD3 = "OWUSD3";

        /// <summary>
        /// OWUSD4.
        /// </summary>
        public const string OWUSD4 = "OWUSD4";

        /// <summary>
        /// OWUSD5.
        /// </summary>
        public const string OWUSD5 = "OWUSD5";

        /// <summary>
        /// OWUAMT01.
        /// </summary>
        public const string OWUAMT01 = "OWUAMT01";

        /// <summary>
        /// OWUAMT02.
        /// </summary>
        public const string OWUAMT02 = "OWUAMT02";

        /// <summary>
        /// OWUAMT03.
        /// </summary>
        public const string OWUAMT03 = "OWUAMT03";

        /// <summary>
        /// OWUAMT04.
        /// </summary>
        public const string OWUAMT04 = "OWUAMT04";

        /// <summary>
        /// OWUAMT05.
        /// </summary>
        public const string OWUAMT05 = "OWUAMT05";

        /// <summary>
        /// OWF1A.
        /// </summary>
        public const string OWF1A = "OWF1A";

        /// <summary>
        /// OWF2A.
        /// </summary>
        public const string OWF2A = "OWF2A";

        /// <summary>
        /// OWF3A.
        /// </summary>
        public const string OWF3A = "OWF3A";

        /// <summary>
        /// OWF4A.
        /// </summary>
        public const string OWF4A = "OWF4A";

        /// <summary>
        /// OWF5A.
        /// </summary>
        public const string OWF5A = "OWF5A";

        /// <summary>
        /// OWCRTU.
        /// </summary>
        public const string OWCRTU = "OWCRTU";

        /// <summary>
        /// OWCRTJ.
        /// </summary>
        public const string OWCRTJ = "OWCRTJ";

        /// <summary>
        /// OWCRTT.
        /// </summary>
        public const string OWCRTT = "OWCRTT";

        /// <summary>
        /// OWWRKSTNID.
        /// </summary>
        public const string OWWRKSTNID = "OWWRKSTNID";

        /// <summary>
        /// OWHBOPID.
        /// </summary>
        public const string OWHBOPID = "OWHBOPID";

        /// <summary>
        /// OWUPMB.
        /// </summary>
        public const string OWUPMB = "OWUPMB";

        /// <summary>
        /// OWUPMJ.
        /// </summary>
        public const string OWUPMJ = "OWUPMJ";

        /// <summary>
        /// OWUPMT.
        /// </summary>
        public const string OWUPMT = "OWUPMT";

        /// <summary>
        /// OWJOBN.
        /// </summary>
        public const string OWJOBN = "OWJOBN";

        /// <summary>
        /// OWPID.
        /// </summary>
        public const string OWPID = "OWPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H401W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OWJOBS", "OWJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("OWHBAREA", "OWHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("OWHBMCUS", "OWHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OWCPHASE", "OWCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("OWHBPLAN", "OWHBPLAN", JdeDataType.String, 8, true, true),
        new JdeField("OWHBELEV", "OWHBELEV", JdeDataType.String, 6, true, true),
        new JdeField("OWOPTION", "OWOPTION", JdeDataType.String, 16, true, true),
        new JdeField("OWDL01", "OWDL01", JdeDataType.String, 60),
        new JdeField("OWDL02", "OWDL02", JdeDataType.String, 60),
        new JdeField("OWDL03", "OWDL03", JdeDataType.String, 60),
        new JdeField("OWDL04", "OWDL04", JdeDataType.String, 60),
        new JdeField("OWDL05", "OWDL05", JdeDataType.String, 60),
        new JdeField("OWDL06", "OWDL06", JdeDataType.String, 60),
        new JdeField("OWHBOAREA", "OWHBOAREA", JdeDataType.String, 6),
        new JdeField("OWHBOMCUS", "OWHBOMCUS", JdeDataType.String, 24),
        new JdeField("OWHBOPLAN", "OWHBOPLAN", JdeDataType.String, 8),
        new JdeField("OWOCPHASE", "OWOCPHASE", JdeDataType.String, 6),
        new JdeField("OWHBOELEV", "OWHBOELEV", JdeDataType.String, 6),
        new JdeField("OWOPTYP", "OWOPTYP", JdeDataType.String, 6),
        new JdeField("OWOPKG", "OWOPKG", JdeDataType.String, 2),
        new JdeField("OWOPKGC", "OWOPKGC", JdeDataType.String, 2),
        new JdeField("OWOCSTM", "OWOCSTM", JdeDataType.String, 2),
        new JdeField("OWHBLOT", "OWHBLOT", JdeDataType.String, 8),
        new JdeField("OWDPTP", "OWDPTP", JdeDataType.Numeric),
        new JdeField("OWCSPR", "OWCSPR", JdeDataType.Numeric),
        new JdeField("OWSPJ", "OWSPJ", JdeDataType.Numeric),
        new JdeField("OWEXDE", "OWEXDE", JdeDataType.Numeric),
        new JdeField("OWHGPP", "OWHGPP", JdeDataType.Numeric),
        new JdeField("OWPSPR", "OWPSPR", JdeDataType.Numeric),
        new JdeField("OWAMTO", "OWAMTO", JdeDataType.Numeric),
        new JdeField("OWSTRT", "OWSTRT", JdeDataType.Numeric),
        new JdeField("OWINACDTJ", "OWINACDTJ", JdeDataType.Numeric),
        new JdeField("OWPLNQ", "OWPLNQ", JdeDataType.String, 50),
        new JdeField("OWOPM01", "OWOPM01", JdeDataType.String, 6),
        new JdeField("OWOPM02", "OWOPM02", JdeDataType.String, 6),
        new JdeField("OWOPM03", "OWOPM03", JdeDataType.String, 6),
        new JdeField("OWOPM04", "OWOPM04", JdeDataType.String, 6),
        new JdeField("OWOPM05", "OWOPM05", JdeDataType.String, 6),
        new JdeField("OWOPM06", "OWOPM06", JdeDataType.String, 6),
        new JdeField("OWOPM07", "OWOPM07", JdeDataType.String, 6),
        new JdeField("OWOPM08", "OWOPM08", JdeDataType.String, 6),
        new JdeField("OWOPM09", "OWOPM09", JdeDataType.String, 6),
        new JdeField("OWOPM10", "OWOPM10", JdeDataType.String, 6),
        new JdeField("OWOPM11", "OWOPM11", JdeDataType.String, 20),
        new JdeField("OWOPM12", "OWOPM12", JdeDataType.String, 20),
        new JdeField("OWOPM13", "OWOPM13", JdeDataType.String, 20),
        new JdeField("OWOPM14", "OWOPM14", JdeDataType.String, 20),
        new JdeField("OWOPM15", "OWOPM15", JdeDataType.String, 20),
        new JdeField("OWOPM16", "OWOPM16", JdeDataType.String, 20),
        new JdeField("OWOPM17", "OWOPM17", JdeDataType.String, 20),
        new JdeField("OWOPM18", "OWOPM18", JdeDataType.String, 20),
        new JdeField("OWOPM19", "OWOPM19", JdeDataType.String, 20),
        new JdeField("OWOPM20", "OWOPM20", JdeDataType.String, 20),
        new JdeField("OWOPSTAV", "OWOPSTAV", JdeDataType.String, 6),
        new JdeField("OWOPSTCO", "OWOPSTCO", JdeDataType.String, 6),
        new JdeField("OWOPLVL", "OWOPLVL", JdeDataType.Numeric),
        new JdeField("OWHBST1", "OWHBST1", JdeDataType.String, 2),
        new JdeField("OWHBST2", "OWHBST2", JdeDataType.String, 2),
        new JdeField("OWHBST3", "OWHBST3", JdeDataType.String, 2),
        new JdeField("OWHBST4", "OWHBST4", JdeDataType.String, 2),
        new JdeField("OWHBST5", "OWHBST5", JdeDataType.String, 2),
        new JdeField("OWUC01", "OWUC01", JdeDataType.String, 2),
        new JdeField("OWUC02", "OWUC02", JdeDataType.String, 2),
        new JdeField("OWUC03", "OWUC03", JdeDataType.String, 2),
        new JdeField("OWUSD1", "OWUSD1", JdeDataType.Numeric),
        new JdeField("OWUSD2", "OWUSD2", JdeDataType.Numeric),
        new JdeField("OWUSD3", "OWUSD3", JdeDataType.Numeric),
        new JdeField("OWUSD4", "OWUSD4", JdeDataType.Numeric),
        new JdeField("OWUSD5", "OWUSD5", JdeDataType.Numeric),
        new JdeField("OWUAMT01", "OWUAMT01", JdeDataType.Numeric),
        new JdeField("OWUAMT02", "OWUAMT02", JdeDataType.Numeric),
        new JdeField("OWUAMT03", "OWUAMT03", JdeDataType.Numeric),
        new JdeField("OWUAMT04", "OWUAMT04", JdeDataType.Numeric),
        new JdeField("OWUAMT05", "OWUAMT05", JdeDataType.Numeric),
        new JdeField("OWF1A", "OWF1A", JdeDataType.Numeric),
        new JdeField("OWF2A", "OWF2A", JdeDataType.Numeric),
        new JdeField("OWF3A", "OWF3A", JdeDataType.Numeric),
        new JdeField("OWF4A", "OWF4A", JdeDataType.Numeric),
        new JdeField("OWF5A", "OWF5A", JdeDataType.Numeric),
        new JdeField("OWCRTU", "OWCRTU", JdeDataType.String, 20),
        new JdeField("OWCRTJ", "OWCRTJ", JdeDataType.Numeric),
        new JdeField("OWCRTT", "OWCRTT", JdeDataType.Numeric),
        new JdeField("OWWRKSTNID", "OWWRKSTNID", JdeDataType.String, 20),
        new JdeField("OWHBOPID", "OWHBOPID", JdeDataType.String, 20),
        new JdeField("OWUPMB", "OWUPMB", JdeDataType.String, 20),
        new JdeField("OWUPMJ", "OWUPMJ", JdeDataType.Numeric),
        new JdeField("OWUPMT", "OWUPMT", JdeDataType.Numeric),
        new JdeField("OWJOBN", "OWJOBN", JdeDataType.String, 20),
        new JdeField("OWPID", "OWPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H401W_0", "Primary Key on OWJOBS, OWHBAREA, OWHBMCUS, OWCPHASE, OWHBPLAN, OWHBELEV, OWOPTION", new[] { "OWJOBS", "OWHBAREA", "OWHBMCUS", "OWCPHASE", "OWHBPLAN", "OWHBELEV", "OWOPTION" }, isUnique: true, isPrimaryKey: true)
    };
}
