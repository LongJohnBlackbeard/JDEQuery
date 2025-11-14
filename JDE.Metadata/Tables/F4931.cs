using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4931 - .
/// </summary>
public class F4931 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VGVTYP.
        /// </summary>
        public const string VGVTYP = "VGVTYP";

        /// <summary>
        /// VGDL01.
        /// </summary>
        public const string VGDL01 = "VGDL01";

        /// <summary>
        /// VGMCU.
        /// </summary>
        public const string VGMCU = "VGMCU";

        /// <summary>
        /// VGMOT.
        /// </summary>
        public const string VGMOT = "VGMOT";

        /// <summary>
        /// VGDSGP.
        /// </summary>
        public const string VGDSGP = "VGDSGP";

        /// <summary>
        /// VGDSGS.
        /// </summary>
        public const string VGDSGS = "VGDSGS";

        /// <summary>
        /// VGNCE.
        /// </summary>
        public const string VGNCE = "VGNCE";

        /// <summary>
        /// VGWTEM.
        /// </summary>
        public const string VGWTEM = "VGWTEM";

        /// <summary>
        /// VGWTCA.
        /// </summary>
        public const string VGWTCA = "VGWTCA";

        /// <summary>
        /// VGWTUM.
        /// </summary>
        public const string VGWTUM = "VGWTUM";

        /// <summary>
        /// VGVLCP.
        /// </summary>
        public const string VGVLCP = "VGVLCP";

        /// <summary>
        /// VGVLCS.
        /// </summary>
        public const string VGVLCS = "VGVLCS";

        /// <summary>
        /// VGVLUM.
        /// </summary>
        public const string VGVLUM = "VGVLUM";

        /// <summary>
        /// VGCVOL.
        /// </summary>
        public const string VGCVOL = "VGCVOL";

        /// <summary>
        /// VGCVUM.
        /// </summary>
        public const string VGCVUM = "VGCVUM";

        /// <summary>
        /// VGLCNT.
        /// </summary>
        public const string VGLCNT = "VGLCNT";

        /// <summary>
        /// VGAXLE.
        /// </summary>
        public const string VGAXLE = "VGAXLE";

        /// <summary>
        /// VGWTAX.
        /// </summary>
        public const string VGWTAX = "VGWTAX";

        /// <summary>
        /// VGSEAL.
        /// </summary>
        public const string VGSEAL = "VGSEAL";

        /// <summary>
        /// VGLNLE.
        /// </summary>
        public const string VGLNLE = "VGLNLE";

        /// <summary>
        /// VGLNWE.
        /// </summary>
        public const string VGLNWE = "VGLNWE";

        /// <summary>
        /// VGLNHE.
        /// </summary>
        public const string VGLNHE = "VGLNHE";

        /// <summary>
        /// VGLNLI.
        /// </summary>
        public const string VGLNLI = "VGLNLI";

        /// <summary>
        /// VGLNWI.
        /// </summary>
        public const string VGLNWI = "VGLNWI";

        /// <summary>
        /// VGLNHR.
        /// </summary>
        public const string VGLNHR = "VGLNHR";

        /// <summary>
        /// VGLNHC.
        /// </summary>
        public const string VGLNHC = "VGLNHC";

        /// <summary>
        /// VGLNHF.
        /// </summary>
        public const string VGLNHF = "VGLNHF";

        /// <summary>
        /// VGLHRD.
        /// </summary>
        public const string VGLHRD = "VGLHRD";

        /// <summary>
        /// VGLWRD.
        /// </summary>
        public const string VGLWRD = "VGLWRD";

        /// <summary>
        /// VGLHSD.
        /// </summary>
        public const string VGLHSD = "VGLHSD";

        /// <summary>
        /// VGLWSD.
        /// </summary>
        public const string VGLWSD = "VGLWSD";

        /// <summary>
        /// VGLNVF.
        /// </summary>
        public const string VGLNVF = "VGLNVF";

        /// <summary>
        /// VGLUOM.
        /// </summary>
        public const string VGLUOM = "VGLUOM";

        /// <summary>
        /// VGCPFG.
        /// </summary>
        public const string VGCPFG = "VGCPFG";

        /// <summary>
        /// VGBPFG.
        /// </summary>
        public const string VGBPFG = "VGBPFG";

        /// <summary>
        /// VGMLLN.
        /// </summary>
        public const string VGMLLN = "VGMLLN";

        /// <summary>
        /// VGURCD.
        /// </summary>
        public const string VGURCD = "VGURCD";

        /// <summary>
        /// VGURDT.
        /// </summary>
        public const string VGURDT = "VGURDT";

        /// <summary>
        /// VGURAB.
        /// </summary>
        public const string VGURAB = "VGURAB";

        /// <summary>
        /// VGURRF.
        /// </summary>
        public const string VGURRF = "VGURRF";

        /// <summary>
        /// VGUSER.
        /// </summary>
        public const string VGUSER = "VGUSER";

        /// <summary>
        /// VGPID.
        /// </summary>
        public const string VGPID = "VGPID";

        /// <summary>
        /// VGJOBN.
        /// </summary>
        public const string VGJOBN = "VGJOBN";

        /// <summary>
        /// VGUPMJ.
        /// </summary>
        public const string VGUPMJ = "VGUPMJ";

        /// <summary>
        /// VGTDAY.
        /// </summary>
        public const string VGTDAY = "VGTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4931";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VGVTYP", "VGVTYP", JdeDataType.String, 24, true, true),
        new JdeField("VGDL01", "VGDL01", JdeDataType.String, 60),
        new JdeField("VGMCU", "VGMCU", JdeDataType.String, 24),
        new JdeField("VGMOT", "VGMOT", JdeDataType.String, 6),
        new JdeField("VGDSGP", "VGDSGP", JdeDataType.String, 6),
        new JdeField("VGDSGS", "VGDSGS", JdeDataType.String, 6),
        new JdeField("VGNCE", "VGNCE", JdeDataType.Numeric),
        new JdeField("VGWTEM", "VGWTEM", JdeDataType.Numeric),
        new JdeField("VGWTCA", "VGWTCA", JdeDataType.Numeric),
        new JdeField("VGWTUM", "VGWTUM", JdeDataType.String, 4),
        new JdeField("VGVLCP", "VGVLCP", JdeDataType.Numeric),
        new JdeField("VGVLCS", "VGVLCS", JdeDataType.Numeric),
        new JdeField("VGVLUM", "VGVLUM", JdeDataType.String, 4),
        new JdeField("VGCVOL", "VGCVOL", JdeDataType.Numeric),
        new JdeField("VGCVUM", "VGCVUM", JdeDataType.String, 4),
        new JdeField("VGLCNT", "VGLCNT", JdeDataType.Numeric),
        new JdeField("VGAXLE", "VGAXLE", JdeDataType.Numeric),
        new JdeField("VGWTAX", "VGWTAX", JdeDataType.Numeric),
        new JdeField("VGSEAL", "VGSEAL", JdeDataType.Numeric),
        new JdeField("VGLNLE", "VGLNLE", JdeDataType.Numeric),
        new JdeField("VGLNWE", "VGLNWE", JdeDataType.Numeric),
        new JdeField("VGLNHE", "VGLNHE", JdeDataType.Numeric),
        new JdeField("VGLNLI", "VGLNLI", JdeDataType.Numeric),
        new JdeField("VGLNWI", "VGLNWI", JdeDataType.Numeric),
        new JdeField("VGLNHR", "VGLNHR", JdeDataType.Numeric),
        new JdeField("VGLNHC", "VGLNHC", JdeDataType.Numeric),
        new JdeField("VGLNHF", "VGLNHF", JdeDataType.Numeric),
        new JdeField("VGLHRD", "VGLHRD", JdeDataType.Numeric),
        new JdeField("VGLWRD", "VGLWRD", JdeDataType.Numeric),
        new JdeField("VGLHSD", "VGLHSD", JdeDataType.Numeric),
        new JdeField("VGLWSD", "VGLWSD", JdeDataType.Numeric),
        new JdeField("VGLNVF", "VGLNVF", JdeDataType.Numeric),
        new JdeField("VGLUOM", "VGLUOM", JdeDataType.String, 4),
        new JdeField("VGCPFG", "VGCPFG", JdeDataType.String, 2),
        new JdeField("VGBPFG", "VGBPFG", JdeDataType.String, 2),
        new JdeField("VGMLLN", "VGMLLN", JdeDataType.String, 2),
        new JdeField("VGURCD", "VGURCD", JdeDataType.String, 4),
        new JdeField("VGURDT", "VGURDT", JdeDataType.Numeric),
        new JdeField("VGURAB", "VGURAB", JdeDataType.Numeric),
        new JdeField("VGURRF", "VGURRF", JdeDataType.String, 30),
        new JdeField("VGUSER", "VGUSER", JdeDataType.String, 20),
        new JdeField("VGPID", "VGPID", JdeDataType.String, 20),
        new JdeField("VGJOBN", "VGJOBN", JdeDataType.String, 20),
        new JdeField("VGUPMJ", "VGUPMJ", JdeDataType.Numeric),
        new JdeField("VGTDAY", "VGTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4931_0", "Primary Key on VGVTYP", new[] { "VGVTYP" }, isUnique: true, isPrimaryKey: true)
    };
}
