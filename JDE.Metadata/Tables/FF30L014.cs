using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF30L014 - .
/// </summary>
public class FF30L014 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BPDFMCU.
        /// </summary>
        public const string BPDFMCU = "BPDFMCU";

        /// <summary>
        /// BPFSCID.
        /// </summary>
        public const string BPFSCID = "BPFSCID";

        /// <summary>
        /// BPDFBDESC.
        /// </summary>
        public const string BPDFBDESC = "BPDFBDESC";

        /// <summary>
        /// BPSYM1.
        /// </summary>
        public const string BPSYM1 = "BPSYM1";

        /// <summary>
        /// BPSYM2.
        /// </summary>
        public const string BPSYM2 = "BPSYM2";

        /// <summary>
        /// BPSYM3.
        /// </summary>
        public const string BPSYM3 = "BPSYM3";

        /// <summary>
        /// BPNUMSHF.
        /// </summary>
        public const string BPNUMSHF = "BPNUMSHF";

        /// <summary>
        /// BPDFWRHR1.
        /// </summary>
        public const string BPDFWRHR1 = "BPDFWRHR1";

        /// <summary>
        /// BPDFWRHR2.
        /// </summary>
        public const string BPDFWRHR2 = "BPDFWRHR2";

        /// <summary>
        /// BPDFWRHR3.
        /// </summary>
        public const string BPDFWRHR3 = "BPDFWRHR3";

        /// <summary>
        /// BPDFWRHR4.
        /// </summary>
        public const string BPDFWRHR4 = "BPDFWRHR4";

        /// <summary>
        /// BPDFWRHR5.
        /// </summary>
        public const string BPDFWRHR5 = "BPDFWRHR5";

        /// <summary>
        /// BPDFWRHR6.
        /// </summary>
        public const string BPDFWRHR6 = "BPDFWRHR6";

        /// <summary>
        /// BPDFSHF1.
        /// </summary>
        public const string BPDFSHF1 = "BPDFSHF1";

        /// <summary>
        /// BPDFSHF2.
        /// </summary>
        public const string BPDFSHF2 = "BPDFSHF2";

        /// <summary>
        /// BPDFSHF3.
        /// </summary>
        public const string BPDFSHF3 = "BPDFSHF3";

        /// <summary>
        /// BPDFSHF4.
        /// </summary>
        public const string BPDFSHF4 = "BPDFSHF4";

        /// <summary>
        /// BPDFSHF5.
        /// </summary>
        public const string BPDFSHF5 = "BPDFSHF5";

        /// <summary>
        /// BPDFSHF6.
        /// </summary>
        public const string BPDFSHF6 = "BPDFSHF6";

        /// <summary>
        /// BPSEPL.
        /// </summary>
        public const string BPSEPL = "BPSEPL";

        /// <summary>
        /// BPSE01.
        /// </summary>
        public const string BPSE01 = "BPSE01";

        /// <summary>
        /// BPSE02.
        /// </summary>
        public const string BPSE02 = "BPSE02";

        /// <summary>
        /// BPSE03.
        /// </summary>
        public const string BPSE03 = "BPSE03";

        /// <summary>
        /// BPSE04.
        /// </summary>
        public const string BPSE04 = "BPSE04";

        /// <summary>
        /// BPSE05.
        /// </summary>
        public const string BPSE05 = "BPSE05";

        /// <summary>
        /// BPSE06.
        /// </summary>
        public const string BPSE06 = "BPSE06";

        /// <summary>
        /// BPSE07.
        /// </summary>
        public const string BPSE07 = "BPSE07";

        /// <summary>
        /// BPSE08.
        /// </summary>
        public const string BPSE08 = "BPSE08";

        /// <summary>
        /// BPSE09.
        /// </summary>
        public const string BPSE09 = "BPSE09";

        /// <summary>
        /// BPSE10.
        /// </summary>
        public const string BPSE10 = "BPSE10";

        /// <summary>
        /// BPLR01.
        /// </summary>
        public const string BPLR01 = "BPLR01";

        /// <summary>
        /// BPLR02.
        /// </summary>
        public const string BPLR02 = "BPLR02";

        /// <summary>
        /// BPLR03.
        /// </summary>
        public const string BPLR03 = "BPLR03";

        /// <summary>
        /// BPLR04.
        /// </summary>
        public const string BPLR04 = "BPLR04";

        /// <summary>
        /// BPLR05.
        /// </summary>
        public const string BPLR05 = "BPLR05";

        /// <summary>
        /// BPLR06.
        /// </summary>
        public const string BPLR06 = "BPLR06";

        /// <summary>
        /// BPLR07.
        /// </summary>
        public const string BPLR07 = "BPLR07";

        /// <summary>
        /// BPLR08.
        /// </summary>
        public const string BPLR08 = "BPLR08";

        /// <summary>
        /// BPLR09.
        /// </summary>
        public const string BPLR09 = "BPLR09";

        /// <summary>
        /// BPLR10.
        /// </summary>
        public const string BPLR10 = "BPLR10";

        /// <summary>
        /// BPURCD.
        /// </summary>
        public const string BPURCD = "BPURCD";

        /// <summary>
        /// BPURDT.
        /// </summary>
        public const string BPURDT = "BPURDT";

        /// <summary>
        /// BPURAT.
        /// </summary>
        public const string BPURAT = "BPURAT";

        /// <summary>
        /// BPURAB.
        /// </summary>
        public const string BPURAB = "BPURAB";

        /// <summary>
        /// BPURRF.
        /// </summary>
        public const string BPURRF = "BPURRF";

        /// <summary>
        /// BPUSER.
        /// </summary>
        public const string BPUSER = "BPUSER";

        /// <summary>
        /// BPMKEY.
        /// </summary>
        public const string BPMKEY = "BPMKEY";

        /// <summary>
        /// BPPID.
        /// </summary>
        public const string BPPID = "BPPID";

        /// <summary>
        /// BPUUPMJ.
        /// </summary>
        public const string BPUUPMJ = "BPUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF30L014";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BPDFMCU", "BPDFMCU", JdeDataType.String, 24, true, true),
        new JdeField("BPFSCID", "BPFSCID", JdeDataType.Numeric, null, true, true),
        new JdeField("BPDFBDESC", "BPDFBDESC", JdeDataType.String, 60),
        new JdeField("BPSYM1", "BPSYM1", JdeDataType.String, 2),
        new JdeField("BPSYM2", "BPSYM2", JdeDataType.String, 2),
        new JdeField("BPSYM3", "BPSYM3", JdeDataType.String, 2),
        new JdeField("BPNUMSHF", "BPNUMSHF", JdeDataType.Numeric),
        new JdeField("BPDFWRHR1", "BPDFWRHR1", JdeDataType.Numeric),
        new JdeField("BPDFWRHR2", "BPDFWRHR2", JdeDataType.Numeric),
        new JdeField("BPDFWRHR3", "BPDFWRHR3", JdeDataType.Numeric),
        new JdeField("BPDFWRHR4", "BPDFWRHR4", JdeDataType.Numeric),
        new JdeField("BPDFWRHR5", "BPDFWRHR5", JdeDataType.Numeric),
        new JdeField("BPDFWRHR6", "BPDFWRHR6", JdeDataType.Numeric),
        new JdeField("BPDFSHF1", "BPDFSHF1", JdeDataType.String, 2),
        new JdeField("BPDFSHF2", "BPDFSHF2", JdeDataType.String, 2),
        new JdeField("BPDFSHF3", "BPDFSHF3", JdeDataType.String, 2),
        new JdeField("BPDFSHF4", "BPDFSHF4", JdeDataType.String, 2),
        new JdeField("BPDFSHF5", "BPDFSHF5", JdeDataType.String, 2),
        new JdeField("BPDFSHF6", "BPDFSHF6", JdeDataType.String, 2),
        new JdeField("BPSEPL", "BPSEPL", JdeDataType.String, 2),
        new JdeField("BPSE01", "BPSE01", JdeDataType.Numeric),
        new JdeField("BPSE02", "BPSE02", JdeDataType.Numeric),
        new JdeField("BPSE03", "BPSE03", JdeDataType.Numeric),
        new JdeField("BPSE04", "BPSE04", JdeDataType.Numeric),
        new JdeField("BPSE05", "BPSE05", JdeDataType.Numeric),
        new JdeField("BPSE06", "BPSE06", JdeDataType.Numeric),
        new JdeField("BPSE07", "BPSE07", JdeDataType.Numeric),
        new JdeField("BPSE08", "BPSE08", JdeDataType.Numeric),
        new JdeField("BPSE09", "BPSE09", JdeDataType.Numeric),
        new JdeField("BPSE10", "BPSE10", JdeDataType.Numeric),
        new JdeField("BPLR01", "BPLR01", JdeDataType.String, 2),
        new JdeField("BPLR02", "BPLR02", JdeDataType.String, 2),
        new JdeField("BPLR03", "BPLR03", JdeDataType.String, 2),
        new JdeField("BPLR04", "BPLR04", JdeDataType.String, 2),
        new JdeField("BPLR05", "BPLR05", JdeDataType.String, 2),
        new JdeField("BPLR06", "BPLR06", JdeDataType.String, 2),
        new JdeField("BPLR07", "BPLR07", JdeDataType.String, 2),
        new JdeField("BPLR08", "BPLR08", JdeDataType.String, 2),
        new JdeField("BPLR09", "BPLR09", JdeDataType.String, 2),
        new JdeField("BPLR10", "BPLR10", JdeDataType.String, 2),
        new JdeField("BPURCD", "BPURCD", JdeDataType.String, 4),
        new JdeField("BPURDT", "BPURDT", JdeDataType.Numeric),
        new JdeField("BPURAT", "BPURAT", JdeDataType.Numeric),
        new JdeField("BPURAB", "BPURAB", JdeDataType.Numeric),
        new JdeField("BPURRF", "BPURRF", JdeDataType.String, 30),
        new JdeField("BPUSER", "BPUSER", JdeDataType.String, 20),
        new JdeField("BPMKEY", "BPMKEY", JdeDataType.String, 30),
        new JdeField("BPPID", "BPPID", JdeDataType.String, 20),
        new JdeField("BPUUPMJ", "BPUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF30L014_0", "Primary Key on BPDFMCU, BPFSCID", new[] { "BPDFMCU", "BPFSCID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("FF30L014_2", "Index on BPFSCID", new[] { "BPFSCID" })
    };
}
