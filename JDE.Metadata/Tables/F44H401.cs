using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H401 - .
/// </summary>
public class F44H401 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OCHBAREA.
        /// </summary>
        public const string OCHBAREA = "OCHBAREA";

        /// <summary>
        /// OCHBMCUS.
        /// </summary>
        public const string OCHBMCUS = "OCHBMCUS";

        /// <summary>
        /// OCCPHASE.
        /// </summary>
        public const string OCCPHASE = "OCCPHASE";

        /// <summary>
        /// OCHBPLAN.
        /// </summary>
        public const string OCHBPLAN = "OCHBPLAN";

        /// <summary>
        /// OCHBELEV.
        /// </summary>
        public const string OCHBELEV = "OCHBELEV";

        /// <summary>
        /// OCOPTION.
        /// </summary>
        public const string OCOPTION = "OCOPTION";

        /// <summary>
        /// OCDL01.
        /// </summary>
        public const string OCDL01 = "OCDL01";

        /// <summary>
        /// OCDL02.
        /// </summary>
        public const string OCDL02 = "OCDL02";

        /// <summary>
        /// OCDL03.
        /// </summary>
        public const string OCDL03 = "OCDL03";

        /// <summary>
        /// OCDL04.
        /// </summary>
        public const string OCDL04 = "OCDL04";

        /// <summary>
        /// OCDL05.
        /// </summary>
        public const string OCDL05 = "OCDL05";

        /// <summary>
        /// OCDL06.
        /// </summary>
        public const string OCDL06 = "OCDL06";

        /// <summary>
        /// OCOPTYP.
        /// </summary>
        public const string OCOPTYP = "OCOPTYP";

        /// <summary>
        /// OCOPKG.
        /// </summary>
        public const string OCOPKG = "OCOPKG";

        /// <summary>
        /// OCOPKGC.
        /// </summary>
        public const string OCOPKGC = "OCOPKGC";

        /// <summary>
        /// OCOCSTM.
        /// </summary>
        public const string OCOCSTM = "OCOCSTM";

        /// <summary>
        /// OCHBLOT.
        /// </summary>
        public const string OCHBLOT = "OCHBLOT";

        /// <summary>
        /// OCDPTP.
        /// </summary>
        public const string OCDPTP = "OCDPTP";

        /// <summary>
        /// OCCSPR.
        /// </summary>
        public const string OCCSPR = "OCCSPR";

        /// <summary>
        /// OCSPJ.
        /// </summary>
        public const string OCSPJ = "OCSPJ";

        /// <summary>
        /// OCEXDE.
        /// </summary>
        public const string OCEXDE = "OCEXDE";

        /// <summary>
        /// OCHGPP.
        /// </summary>
        public const string OCHGPP = "OCHGPP";

        /// <summary>
        /// OCPSPR.
        /// </summary>
        public const string OCPSPR = "OCPSPR";

        /// <summary>
        /// OCAMTO.
        /// </summary>
        public const string OCAMTO = "OCAMTO";

        /// <summary>
        /// OCSTRT.
        /// </summary>
        public const string OCSTRT = "OCSTRT";

        /// <summary>
        /// OCINACDTJ.
        /// </summary>
        public const string OCINACDTJ = "OCINACDTJ";

        /// <summary>
        /// OCPLNQ.
        /// </summary>
        public const string OCPLNQ = "OCPLNQ";

        /// <summary>
        /// OCOPM01.
        /// </summary>
        public const string OCOPM01 = "OCOPM01";

        /// <summary>
        /// OCOPM02.
        /// </summary>
        public const string OCOPM02 = "OCOPM02";

        /// <summary>
        /// OCOPM03.
        /// </summary>
        public const string OCOPM03 = "OCOPM03";

        /// <summary>
        /// OCOPM04.
        /// </summary>
        public const string OCOPM04 = "OCOPM04";

        /// <summary>
        /// OCOPM05.
        /// </summary>
        public const string OCOPM05 = "OCOPM05";

        /// <summary>
        /// OCOPM06.
        /// </summary>
        public const string OCOPM06 = "OCOPM06";

        /// <summary>
        /// OCOPM07.
        /// </summary>
        public const string OCOPM07 = "OCOPM07";

        /// <summary>
        /// OCOPM08.
        /// </summary>
        public const string OCOPM08 = "OCOPM08";

        /// <summary>
        /// OCOPM09.
        /// </summary>
        public const string OCOPM09 = "OCOPM09";

        /// <summary>
        /// OCOPM10.
        /// </summary>
        public const string OCOPM10 = "OCOPM10";

        /// <summary>
        /// OCOPM11.
        /// </summary>
        public const string OCOPM11 = "OCOPM11";

        /// <summary>
        /// OCOPM12.
        /// </summary>
        public const string OCOPM12 = "OCOPM12";

        /// <summary>
        /// OCOPM13.
        /// </summary>
        public const string OCOPM13 = "OCOPM13";

        /// <summary>
        /// OCOPM14.
        /// </summary>
        public const string OCOPM14 = "OCOPM14";

        /// <summary>
        /// OCOPM15.
        /// </summary>
        public const string OCOPM15 = "OCOPM15";

        /// <summary>
        /// OCOPM16.
        /// </summary>
        public const string OCOPM16 = "OCOPM16";

        /// <summary>
        /// OCOPM17.
        /// </summary>
        public const string OCOPM17 = "OCOPM17";

        /// <summary>
        /// OCOPM18.
        /// </summary>
        public const string OCOPM18 = "OCOPM18";

        /// <summary>
        /// OCOPM19.
        /// </summary>
        public const string OCOPM19 = "OCOPM19";

        /// <summary>
        /// OCOPM20.
        /// </summary>
        public const string OCOPM20 = "OCOPM20";

        /// <summary>
        /// OCOPSTAV.
        /// </summary>
        public const string OCOPSTAV = "OCOPSTAV";

        /// <summary>
        /// OCOPSTCO.
        /// </summary>
        public const string OCOPSTCO = "OCOPSTCO";

        /// <summary>
        /// OCOPLVL.
        /// </summary>
        public const string OCOPLVL = "OCOPLVL";

        /// <summary>
        /// OCHBST1.
        /// </summary>
        public const string OCHBST1 = "OCHBST1";

        /// <summary>
        /// OCHBST2.
        /// </summary>
        public const string OCHBST2 = "OCHBST2";

        /// <summary>
        /// OCHBST3.
        /// </summary>
        public const string OCHBST3 = "OCHBST3";

        /// <summary>
        /// OCHBST4.
        /// </summary>
        public const string OCHBST4 = "OCHBST4";

        /// <summary>
        /// OCHBST5.
        /// </summary>
        public const string OCHBST5 = "OCHBST5";

        /// <summary>
        /// OCUC01.
        /// </summary>
        public const string OCUC01 = "OCUC01";

        /// <summary>
        /// OCUC02.
        /// </summary>
        public const string OCUC02 = "OCUC02";

        /// <summary>
        /// OCUC03.
        /// </summary>
        public const string OCUC03 = "OCUC03";

        /// <summary>
        /// OCUSD1.
        /// </summary>
        public const string OCUSD1 = "OCUSD1";

        /// <summary>
        /// OCUSD2.
        /// </summary>
        public const string OCUSD2 = "OCUSD2";

        /// <summary>
        /// OCUSD3.
        /// </summary>
        public const string OCUSD3 = "OCUSD3";

        /// <summary>
        /// OCUSD4.
        /// </summary>
        public const string OCUSD4 = "OCUSD4";

        /// <summary>
        /// OCUSD5.
        /// </summary>
        public const string OCUSD5 = "OCUSD5";

        /// <summary>
        /// OCUAMT01.
        /// </summary>
        public const string OCUAMT01 = "OCUAMT01";

        /// <summary>
        /// OCUAMT02.
        /// </summary>
        public const string OCUAMT02 = "OCUAMT02";

        /// <summary>
        /// OCUAMT03.
        /// </summary>
        public const string OCUAMT03 = "OCUAMT03";

        /// <summary>
        /// OCUAMT04.
        /// </summary>
        public const string OCUAMT04 = "OCUAMT04";

        /// <summary>
        /// OCUAMT05.
        /// </summary>
        public const string OCUAMT05 = "OCUAMT05";

        /// <summary>
        /// OCF1A.
        /// </summary>
        public const string OCF1A = "OCF1A";

        /// <summary>
        /// OCF2A.
        /// </summary>
        public const string OCF2A = "OCF2A";

        /// <summary>
        /// OCF3A.
        /// </summary>
        public const string OCF3A = "OCF3A";

        /// <summary>
        /// OCF4A.
        /// </summary>
        public const string OCF4A = "OCF4A";

        /// <summary>
        /// OCF5A.
        /// </summary>
        public const string OCF5A = "OCF5A";

        /// <summary>
        /// OCCRTU.
        /// </summary>
        public const string OCCRTU = "OCCRTU";

        /// <summary>
        /// OCCRTJ.
        /// </summary>
        public const string OCCRTJ = "OCCRTJ";

        /// <summary>
        /// OCCRTT.
        /// </summary>
        public const string OCCRTT = "OCCRTT";

        /// <summary>
        /// OCWRKSTNID.
        /// </summary>
        public const string OCWRKSTNID = "OCWRKSTNID";

        /// <summary>
        /// OCHBOPID.
        /// </summary>
        public const string OCHBOPID = "OCHBOPID";

        /// <summary>
        /// OCUPMB.
        /// </summary>
        public const string OCUPMB = "OCUPMB";

        /// <summary>
        /// OCUPMJ.
        /// </summary>
        public const string OCUPMJ = "OCUPMJ";

        /// <summary>
        /// OCUPMT.
        /// </summary>
        public const string OCUPMT = "OCUPMT";

        /// <summary>
        /// OCJOBN.
        /// </summary>
        public const string OCJOBN = "OCJOBN";

        /// <summary>
        /// OCPID.
        /// </summary>
        public const string OCPID = "OCPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H401";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OCHBAREA", "OCHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("OCHBMCUS", "OCHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("OCCPHASE", "OCCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("OCHBPLAN", "OCHBPLAN", JdeDataType.String, 8, true, true),
        new JdeField("OCHBELEV", "OCHBELEV", JdeDataType.String, 6, true, true),
        new JdeField("OCOPTION", "OCOPTION", JdeDataType.String, 16, true, true),
        new JdeField("OCDL01", "OCDL01", JdeDataType.String, 60),
        new JdeField("OCDL02", "OCDL02", JdeDataType.String, 60),
        new JdeField("OCDL03", "OCDL03", JdeDataType.String, 60),
        new JdeField("OCDL04", "OCDL04", JdeDataType.String, 60),
        new JdeField("OCDL05", "OCDL05", JdeDataType.String, 60),
        new JdeField("OCDL06", "OCDL06", JdeDataType.String, 60),
        new JdeField("OCOPTYP", "OCOPTYP", JdeDataType.String, 6),
        new JdeField("OCOPKG", "OCOPKG", JdeDataType.String, 2),
        new JdeField("OCOPKGC", "OCOPKGC", JdeDataType.String, 2),
        new JdeField("OCOCSTM", "OCOCSTM", JdeDataType.String, 2),
        new JdeField("OCHBLOT", "OCHBLOT", JdeDataType.String, 8),
        new JdeField("OCDPTP", "OCDPTP", JdeDataType.Numeric),
        new JdeField("OCCSPR", "OCCSPR", JdeDataType.Numeric),
        new JdeField("OCSPJ", "OCSPJ", JdeDataType.Numeric),
        new JdeField("OCEXDE", "OCEXDE", JdeDataType.Numeric),
        new JdeField("OCHGPP", "OCHGPP", JdeDataType.Numeric),
        new JdeField("OCPSPR", "OCPSPR", JdeDataType.Numeric),
        new JdeField("OCAMTO", "OCAMTO", JdeDataType.Numeric),
        new JdeField("OCSTRT", "OCSTRT", JdeDataType.Numeric),
        new JdeField("OCINACDTJ", "OCINACDTJ", JdeDataType.Numeric),
        new JdeField("OCPLNQ", "OCPLNQ", JdeDataType.String, 50),
        new JdeField("OCOPM01", "OCOPM01", JdeDataType.String, 6),
        new JdeField("OCOPM02", "OCOPM02", JdeDataType.String, 6),
        new JdeField("OCOPM03", "OCOPM03", JdeDataType.String, 6),
        new JdeField("OCOPM04", "OCOPM04", JdeDataType.String, 6),
        new JdeField("OCOPM05", "OCOPM05", JdeDataType.String, 6),
        new JdeField("OCOPM06", "OCOPM06", JdeDataType.String, 6),
        new JdeField("OCOPM07", "OCOPM07", JdeDataType.String, 6),
        new JdeField("OCOPM08", "OCOPM08", JdeDataType.String, 6),
        new JdeField("OCOPM09", "OCOPM09", JdeDataType.String, 6),
        new JdeField("OCOPM10", "OCOPM10", JdeDataType.String, 6),
        new JdeField("OCOPM11", "OCOPM11", JdeDataType.String, 20),
        new JdeField("OCOPM12", "OCOPM12", JdeDataType.String, 20),
        new JdeField("OCOPM13", "OCOPM13", JdeDataType.String, 20),
        new JdeField("OCOPM14", "OCOPM14", JdeDataType.String, 20),
        new JdeField("OCOPM15", "OCOPM15", JdeDataType.String, 20),
        new JdeField("OCOPM16", "OCOPM16", JdeDataType.String, 20),
        new JdeField("OCOPM17", "OCOPM17", JdeDataType.String, 20),
        new JdeField("OCOPM18", "OCOPM18", JdeDataType.String, 20),
        new JdeField("OCOPM19", "OCOPM19", JdeDataType.String, 20),
        new JdeField("OCOPM20", "OCOPM20", JdeDataType.String, 20),
        new JdeField("OCOPSTAV", "OCOPSTAV", JdeDataType.String, 6),
        new JdeField("OCOPSTCO", "OCOPSTCO", JdeDataType.String, 6),
        new JdeField("OCOPLVL", "OCOPLVL", JdeDataType.Numeric),
        new JdeField("OCHBST1", "OCHBST1", JdeDataType.String, 2),
        new JdeField("OCHBST2", "OCHBST2", JdeDataType.String, 2),
        new JdeField("OCHBST3", "OCHBST3", JdeDataType.String, 2),
        new JdeField("OCHBST4", "OCHBST4", JdeDataType.String, 2),
        new JdeField("OCHBST5", "OCHBST5", JdeDataType.String, 2),
        new JdeField("OCUC01", "OCUC01", JdeDataType.String, 2),
        new JdeField("OCUC02", "OCUC02", JdeDataType.String, 2),
        new JdeField("OCUC03", "OCUC03", JdeDataType.String, 2),
        new JdeField("OCUSD1", "OCUSD1", JdeDataType.Numeric),
        new JdeField("OCUSD2", "OCUSD2", JdeDataType.Numeric),
        new JdeField("OCUSD3", "OCUSD3", JdeDataType.Numeric),
        new JdeField("OCUSD4", "OCUSD4", JdeDataType.Numeric),
        new JdeField("OCUSD5", "OCUSD5", JdeDataType.Numeric),
        new JdeField("OCUAMT01", "OCUAMT01", JdeDataType.Numeric),
        new JdeField("OCUAMT02", "OCUAMT02", JdeDataType.Numeric),
        new JdeField("OCUAMT03", "OCUAMT03", JdeDataType.Numeric),
        new JdeField("OCUAMT04", "OCUAMT04", JdeDataType.Numeric),
        new JdeField("OCUAMT05", "OCUAMT05", JdeDataType.Numeric),
        new JdeField("OCF1A", "OCF1A", JdeDataType.Numeric),
        new JdeField("OCF2A", "OCF2A", JdeDataType.Numeric),
        new JdeField("OCF3A", "OCF3A", JdeDataType.Numeric),
        new JdeField("OCF4A", "OCF4A", JdeDataType.Numeric),
        new JdeField("OCF5A", "OCF5A", JdeDataType.Numeric),
        new JdeField("OCCRTU", "OCCRTU", JdeDataType.String, 20),
        new JdeField("OCCRTJ", "OCCRTJ", JdeDataType.Numeric),
        new JdeField("OCCRTT", "OCCRTT", JdeDataType.Numeric),
        new JdeField("OCWRKSTNID", "OCWRKSTNID", JdeDataType.String, 20),
        new JdeField("OCHBOPID", "OCHBOPID", JdeDataType.String, 20),
        new JdeField("OCUPMB", "OCUPMB", JdeDataType.String, 20),
        new JdeField("OCUPMJ", "OCUPMJ", JdeDataType.Numeric),
        new JdeField("OCUPMT", "OCUPMT", JdeDataType.Numeric),
        new JdeField("OCJOBN", "OCJOBN", JdeDataType.String, 20),
        new JdeField("OCPID", "OCPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H401_0", "Primary Key on OCHBAREA, OCHBMCUS, OCCPHASE, OCHBPLAN, OCHBELEV, OCOPTION", new[] { "OCHBAREA", "OCHBMCUS", "OCCPHASE", "OCHBPLAN", "OCHBELEV", "OCOPTION" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H401_2", "Index on OCHBAREA, OCCPHASE, OCHBPLAN, OCHBELEV, OCOPTION", new[] { "OCHBAREA", "OCCPHASE", "OCHBPLAN", "OCHBELEV", "OCOPTION" }),
        new JdeIndex("F44H401_3", "Index on OCHBAREA, OCOPTION", new[] { "OCHBAREA", "OCOPTION" })
    };
}
