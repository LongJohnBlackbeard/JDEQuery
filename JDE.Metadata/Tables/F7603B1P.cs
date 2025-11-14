using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7603B1P - .
/// </summary>
public class F7603B1P : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BPDOC.
        /// </summary>
        public const string BPDOC = "BPDOC";

        /// <summary>
        /// BPDCT.
        /// </summary>
        public const string BPDCT = "BPDCT";

        /// <summary>
        /// BPKCO.
        /// </summary>
        public const string BPKCO = "BPKCO";

        /// <summary>
        /// BPSFX.
        /// </summary>
        public const string BPSFX = "BPSFX";

        /// <summary>
        /// BPAN8.
        /// </summary>
        public const string BPAN8 = "BPAN8";

        /// <summary>
        /// BPTXR1.
        /// </summary>
        public const string BPTXR1 = "BPTXR1";

        /// <summary>
        /// BPAA.
        /// </summary>
        public const string BPAA = "BPAA";

        /// <summary>
        /// BPJMSB.
        /// </summary>
        public const string BPJMSB = "BPJMSB";

        /// <summary>
        /// BPABRB.
        /// </summary>
        public const string BPABRB = "BPABRB";

        /// <summary>
        /// BPDIRB.
        /// </summary>
        public const string BPDIRB = "BPDIRB";

        /// <summary>
        /// BPAA1.
        /// </summary>
        public const string BPAA1 = "BPAA1";

        /// <summary>
        /// BPBBDN.
        /// </summary>
        public const string BPBBDN = "BPBBDN";

        /// <summary>
        /// BPBPIN.
        /// </summary>
        public const string BPBPIN = "BPBPIN";

        /// <summary>
        /// BPBPDA.
        /// </summary>
        public const string BPBPDA = "BPBPDA";

        /// <summary>
        /// BPINMG.
        /// </summary>
        public const string BPINMG = "BPINMG";

        /// <summary>
        /// BPBSCB.
        /// </summary>
        public const string BPBSCB = "BPBSCB";

        /// <summary>
        /// BPBRCB.
        /// </summary>
        public const string BPBRCB = "BPBRCB";

        /// <summary>
        /// BPBBSB.
        /// </summary>
        public const string BPBBSB = "BPBBSB";

        /// <summary>
        /// BPBKCD.
        /// </summary>
        public const string BPBKCD = "BPBKCD";

        /// <summary>
        /// BPTORG.
        /// </summary>
        public const string BPTORG = "BPTORG";

        /// <summary>
        /// BPUSER.
        /// </summary>
        public const string BPUSER = "BPUSER";

        /// <summary>
        /// BPPID.
        /// </summary>
        public const string BPPID = "BPPID";

        /// <summary>
        /// BPUPMJ.
        /// </summary>
        public const string BPUPMJ = "BPUPMJ";

        /// <summary>
        /// BPUPMT.
        /// </summary>
        public const string BPUPMT = "BPUPMT";

        /// <summary>
        /// BPJOBN.
        /// </summary>
        public const string BPJOBN = "BPJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F7603B1P";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BPDOC", "BPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("BPDCT", "BPDCT", JdeDataType.String, 4, true, true),
        new JdeField("BPKCO", "BPKCO", JdeDataType.String, 10, true, true),
        new JdeField("BPSFX", "BPSFX", JdeDataType.String, 6, true, true),
        new JdeField("BPAN8", "BPAN8", JdeDataType.Numeric),
        new JdeField("BPTXR1", "BPTXR1", JdeDataType.Numeric),
        new JdeField("BPAA", "BPAA", JdeDataType.Numeric),
        new JdeField("BPJMSB", "BPJMSB", JdeDataType.Numeric),
        new JdeField("BPABRB", "BPABRB", JdeDataType.Numeric),
        new JdeField("BPDIRB", "BPDIRB", JdeDataType.Numeric),
        new JdeField("BPAA1", "BPAA1", JdeDataType.Numeric),
        new JdeField("BPBBDN", "BPBBDN", JdeDataType.String, 30),
        new JdeField("BPBPIN", "BPBPIN", JdeDataType.Numeric),
        new JdeField("BPBPDA", "BPBPDA", JdeDataType.Numeric),
        new JdeField("BPINMG", "BPINMG", JdeDataType.String, 20),
        new JdeField("BPBSCB", "BPBSCB", JdeDataType.String, 4),
        new JdeField("BPBRCB", "BPBRCB", JdeDataType.String, 4),
        new JdeField("BPBBSB", "BPBBSB", JdeDataType.String, 2),
        new JdeField("BPBKCD", "BPBKCD", JdeDataType.String, 6),
        new JdeField("BPTORG", "BPTORG", JdeDataType.String, 20),
        new JdeField("BPUSER", "BPUSER", JdeDataType.String, 20),
        new JdeField("BPPID", "BPPID", JdeDataType.String, 20),
        new JdeField("BPUPMJ", "BPUPMJ", JdeDataType.Numeric),
        new JdeField("BPUPMT", "BPUPMT", JdeDataType.Numeric),
        new JdeField("BPJOBN", "BPJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7603B1P_0", "Primary Key on BPDOC, BPDCT, BPKCO, BPSFX", new[] { "BPDOC", "BPDCT", "BPKCO", "BPSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
