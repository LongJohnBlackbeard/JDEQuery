using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F44H0929 - .
/// </summary>
public class F44H0929 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDHBAREA.
        /// </summary>
        public const string EDHBAREA = "EDHBAREA";

        /// <summary>
        /// EDHBMCUS.
        /// </summary>
        public const string EDHBMCUS = "EDHBMCUS";

        /// <summary>
        /// EDCPHASE.
        /// </summary>
        public const string EDCPHASE = "EDCPHASE";

        /// <summary>
        /// EDHBLOT.
        /// </summary>
        public const string EDHBLOT = "EDHBLOT";

        /// <summary>
        /// EDCSSEQ.
        /// </summary>
        public const string EDCSSEQ = "EDCSSEQ";

        /// <summary>
        /// EDHBPLAN.
        /// </summary>
        public const string EDHBPLAN = "EDHBPLAN";

        /// <summary>
        /// EDHBELEV.
        /// </summary>
        public const string EDHBELEV = "EDHBELEV";

        /// <summary>
        /// EDOPTION.
        /// </summary>
        public const string EDOPTION = "EDOPTION";

        /// <summary>
        /// EDSDTYP.
        /// </summary>
        public const string EDSDTYP = "EDSDTYP";

        /// <summary>
        /// EDSDKY.
        /// </summary>
        public const string EDSDKY = "EDSDKY";

        /// <summary>
        /// EDSDLIN.
        /// </summary>
        public const string EDSDLIN = "EDSDLIN";

        /// <summary>
        /// EDSDDSC.
        /// </summary>
        public const string EDSDDSC = "EDSDDSC";

        /// <summary>
        /// EDSDDT1.
        /// </summary>
        public const string EDSDDT1 = "EDSDDT1";

        /// <summary>
        /// EDSDDT2.
        /// </summary>
        public const string EDSDDT2 = "EDSDDT2";

        /// <summary>
        /// EDSDDT3.
        /// </summary>
        public const string EDSDDT3 = "EDSDDT3";

        /// <summary>
        /// EDSDAMT1.
        /// </summary>
        public const string EDSDAMT1 = "EDSDAMT1";

        /// <summary>
        /// EDSDAMT2.
        /// </summary>
        public const string EDSDAMT2 = "EDSDAMT2";

        /// <summary>
        /// EDSDAMT3.
        /// </summary>
        public const string EDSDAMT3 = "EDSDAMT3";

        /// <summary>
        /// EDSDNM1.
        /// </summary>
        public const string EDSDNM1 = "EDSDNM1";

        /// <summary>
        /// EDSDNM2.
        /// </summary>
        public const string EDSDNM2 = "EDSDNM2";

        /// <summary>
        /// EDSDNM3.
        /// </summary>
        public const string EDSDNM3 = "EDSDNM3";

        /// <summary>
        /// EDSDMO1.
        /// </summary>
        public const string EDSDMO1 = "EDSDMO1";

        /// <summary>
        /// EDSDMO2.
        /// </summary>
        public const string EDSDMO2 = "EDSDMO2";

        /// <summary>
        /// EDSDMO3.
        /// </summary>
        public const string EDSDMO3 = "EDSDMO3";

        /// <summary>
        /// EDSDAB1.
        /// </summary>
        public const string EDSDAB1 = "EDSDAB1";

        /// <summary>
        /// EDSDAB2.
        /// </summary>
        public const string EDSDAB2 = "EDSDAB2";

        /// <summary>
        /// EDSDAB3.
        /// </summary>
        public const string EDSDAB3 = "EDSDAB3";

        /// <summary>
        /// EDSDTXT.
        /// </summary>
        public const string EDSDTXT = "EDSDTXT";

        /// <summary>
        /// EDPRODM.
        /// </summary>
        public const string EDPRODM = "EDPRODM";

        /// <summary>
        /// EDPRODF.
        /// </summary>
        public const string EDPRODF = "EDPRODF";

        /// <summary>
        /// EDEDTLVL.
        /// </summary>
        public const string EDEDTLVL = "EDEDTLVL";

        /// <summary>
        /// EDEDUPDF.
        /// </summary>
        public const string EDEDUPDF = "EDEDUPDF";

        /// <summary>
        /// EDEDSELFLG.
        /// </summary>
        public const string EDEDSELFLG = "EDEDSELFLG";

        /// <summary>
        /// EDCRTU.
        /// </summary>
        public const string EDCRTU = "EDCRTU";

        /// <summary>
        /// EDCRTJ.
        /// </summary>
        public const string EDCRTJ = "EDCRTJ";

        /// <summary>
        /// EDCRTT.
        /// </summary>
        public const string EDCRTT = "EDCRTT";

        /// <summary>
        /// EDWRKSTNID.
        /// </summary>
        public const string EDWRKSTNID = "EDWRKSTNID";

        /// <summary>
        /// EDHBOPID.
        /// </summary>
        public const string EDHBOPID = "EDHBOPID";

        /// <summary>
        /// EDUPMB.
        /// </summary>
        public const string EDUPMB = "EDUPMB";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDUPMT.
        /// </summary>
        public const string EDUPMT = "EDUPMT";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F44H0929";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDHBAREA", "EDHBAREA", JdeDataType.String, 6, true, true),
        new JdeField("EDHBMCUS", "EDHBMCUS", JdeDataType.String, 24, true, true),
        new JdeField("EDCPHASE", "EDCPHASE", JdeDataType.String, 6, true, true),
        new JdeField("EDHBLOT", "EDHBLOT", JdeDataType.String, 8, true, true),
        new JdeField("EDCSSEQ", "EDCSSEQ", JdeDataType.String, 6, true, true),
        new JdeField("EDHBPLAN", "EDHBPLAN", JdeDataType.String, 8, true, true),
        new JdeField("EDHBELEV", "EDHBELEV", JdeDataType.String, 6, true, true),
        new JdeField("EDOPTION", "EDOPTION", JdeDataType.String, 16, true, true),
        new JdeField("EDSDTYP", "EDSDTYP", JdeDataType.String, 6, true, true),
        new JdeField("EDSDKY", "EDSDKY", JdeDataType.String, 20, true, true),
        new JdeField("EDSDLIN", "EDSDLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDSDDSC", "EDSDDSC", JdeDataType.String, 100),
        new JdeField("EDSDDT1", "EDSDDT1", JdeDataType.Numeric),
        new JdeField("EDSDDT2", "EDSDDT2", JdeDataType.Numeric),
        new JdeField("EDSDDT3", "EDSDDT3", JdeDataType.Numeric),
        new JdeField("EDSDAMT1", "EDSDAMT1", JdeDataType.Numeric),
        new JdeField("EDSDAMT2", "EDSDAMT2", JdeDataType.Numeric),
        new JdeField("EDSDAMT3", "EDSDAMT3", JdeDataType.Numeric),
        new JdeField("EDSDNM1", "EDSDNM1", JdeDataType.Numeric),
        new JdeField("EDSDNM2", "EDSDNM2", JdeDataType.Numeric),
        new JdeField("EDSDNM3", "EDSDNM3", JdeDataType.Numeric),
        new JdeField("EDSDMO1", "EDSDMO1", JdeDataType.String, 40),
        new JdeField("EDSDMO2", "EDSDMO2", JdeDataType.String, 40),
        new JdeField("EDSDMO3", "EDSDMO3", JdeDataType.String, 40),
        new JdeField("EDSDAB1", "EDSDAB1", JdeDataType.Numeric),
        new JdeField("EDSDAB2", "EDSDAB2", JdeDataType.Numeric),
        new JdeField("EDSDAB3", "EDSDAB3", JdeDataType.Numeric),
        new JdeField("EDSDTXT", "EDSDTXT", JdeDataType.String, 160),
        new JdeField("EDPRODM", "EDPRODM", JdeDataType.String, 16),
        new JdeField("EDPRODF", "EDPRODF", JdeDataType.String, 16),
        new JdeField("EDEDTLVL", "EDEDTLVL", JdeDataType.String, 2),
        new JdeField("EDEDUPDF", "EDEDUPDF", JdeDataType.String, 2),
        new JdeField("EDEDSELFLG", "EDEDSELFLG", JdeDataType.String, 2),
        new JdeField("EDCRTU", "EDCRTU", JdeDataType.String, 20),
        new JdeField("EDCRTJ", "EDCRTJ", JdeDataType.Numeric),
        new JdeField("EDCRTT", "EDCRTT", JdeDataType.Numeric),
        new JdeField("EDWRKSTNID", "EDWRKSTNID", JdeDataType.String, 20),
        new JdeField("EDHBOPID", "EDHBOPID", JdeDataType.String, 20),
        new JdeField("EDUPMB", "EDUPMB", JdeDataType.String, 20),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDUPMT", "EDUPMT", JdeDataType.Numeric),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F44H0929_0", "Primary Key on EDHBAREA, EDHBMCUS, EDCPHASE, EDHBLOT, EDCSSEQ, EDHBPLAN, EDHBELEV, EDOPTION, EDSDTYP, EDSDKY, EDSDLIN", new[] { "EDHBAREA", "EDHBMCUS", "EDCPHASE", "EDHBLOT", "EDCSSEQ", "EDHBPLAN", "EDHBELEV", "EDOPTION", "EDSDTYP", "EDSDKY", "EDSDLIN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F44H0929_2", "Index on EDHBAREA, EDHBMCUS, EDSDTYP, EDSDKY, EDSDLIN, SYS_NC00044$", new[] { "EDHBAREA", "EDHBMCUS", "EDSDTYP", "EDSDKY", "EDSDLIN", "SYS_NC00044$" })
    };
}
