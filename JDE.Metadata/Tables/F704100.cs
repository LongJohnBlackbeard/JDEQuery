using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F704100 - .
/// </summary>
public class F704100 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VAKCO.
        /// </summary>
        public const string VAKCO = "VAKCO";

        /// <summary>
        /// VADCT.
        /// </summary>
        public const string VADCT = "VADCT";

        /// <summary>
        /// VADOC.
        /// </summary>
        public const string VADOC = "VADOC";

        /// <summary>
        /// VASFX.
        /// </summary>
        public const string VASFX = "VASFX";

        /// <summary>
        /// VASFXE.
        /// </summary>
        public const string VASFXE = "VASFXE";

        /// <summary>
        /// VAGL01.
        /// </summary>
        public const string VAGL01 = "VAGL01";

        /// <summary>
        /// VACO.
        /// </summary>
        public const string VACO = "VACO";

        /// <summary>
        /// VAAN8.
        /// </summary>
        public const string VAAN8 = "VAAN8";

        /// <summary>
        /// VAICU.
        /// </summary>
        public const string VAICU = "VAICU";

        /// <summary>
        /// VAICUT.
        /// </summary>
        public const string VAICUT = "VAICUT";

        /// <summary>
        /// VATXA1.
        /// </summary>
        public const string VATXA1 = "VATXA1";

        /// <summary>
        /// VAEXR1.
        /// </summary>
        public const string VAEXR1 = "VAEXR1";

        /// <summary>
        /// VAITM.
        /// </summary>
        public const string VAITM = "VAITM";

        /// <summary>
        /// VAAID.
        /// </summary>
        public const string VAAID = "VAAID";

        /// <summary>
        /// VAVOD.
        /// </summary>
        public const string VAVOD = "VAVOD";

        /// <summary>
        /// VACRCD.
        /// </summary>
        public const string VACRCD = "VACRCD";

        /// <summary>
        /// VADGJ.
        /// </summary>
        public const string VADGJ = "VADGJ";

        /// <summary>
        /// VADIVJ.
        /// </summary>
        public const string VADIVJ = "VADIVJ";

        /// <summary>
        /// VASTAM.
        /// </summary>
        public const string VASTAM = "VASTAM";

        /// <summary>
        /// VAAAP.
        /// </summary>
        public const string VAAAP = "VAAAP";

        /// <summary>
        /// VACTAM.
        /// </summary>
        public const string VACTAM = "VACTAM";

        /// <summary>
        /// VAFOPN.
        /// </summary>
        public const string VAFOPN = "VAFOPN";

        /// <summary>
        /// VATXR1.
        /// </summary>
        public const string VATXR1 = "VATXR1";

        /// <summary>
        /// VATXR2.
        /// </summary>
        public const string VATXR2 = "VATXR2";

        /// <summary>
        /// VATXR3.
        /// </summary>
        public const string VATXR3 = "VATXR3";

        /// <summary>
        /// VATXR4.
        /// </summary>
        public const string VATXR4 = "VATXR4";

        /// <summary>
        /// VATXR5.
        /// </summary>
        public const string VATXR5 = "VATXR5";

        /// <summary>
        /// VAK70MTHD.
        /// </summary>
        public const string VAK70MTHD = "VAK70MTHD";

        /// <summary>
        /// VAK70VSTA.
        /// </summary>
        public const string VAK70VSTA = "VAK70VSTA";

        /// <summary>
        /// VAUSER.
        /// </summary>
        public const string VAUSER = "VAUSER";

        /// <summary>
        /// VAPID.
        /// </summary>
        public const string VAPID = "VAPID";

        /// <summary>
        /// VAJOBN.
        /// </summary>
        public const string VAJOBN = "VAJOBN";

        /// <summary>
        /// VAUPMJ.
        /// </summary>
        public const string VAUPMJ = "VAUPMJ";

        /// <summary>
        /// VAUPMT.
        /// </summary>
        public const string VAUPMT = "VAUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F704100";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VAKCO", "VAKCO", JdeDataType.String, 10, true, true),
        new JdeField("VADCT", "VADCT", JdeDataType.String, 4, true, true),
        new JdeField("VADOC", "VADOC", JdeDataType.Numeric, null, true, true),
        new JdeField("VASFX", "VASFX", JdeDataType.String, 6, true, true),
        new JdeField("VASFXE", "VASFXE", JdeDataType.Numeric, null, true, true),
        new JdeField("VAGL01", "VAGL01", JdeDataType.String, 8, true, true),
        new JdeField("VACO", "VACO", JdeDataType.String, 10),
        new JdeField("VAAN8", "VAAN8", JdeDataType.Numeric),
        new JdeField("VAICU", "VAICU", JdeDataType.Numeric),
        new JdeField("VAICUT", "VAICUT", JdeDataType.String, 4),
        new JdeField("VATXA1", "VATXA1", JdeDataType.String, 20),
        new JdeField("VAEXR1", "VAEXR1", JdeDataType.String, 4),
        new JdeField("VAITM", "VAITM", JdeDataType.Numeric),
        new JdeField("VAAID", "VAAID", JdeDataType.String, 16),
        new JdeField("VAVOD", "VAVOD", JdeDataType.String, 2),
        new JdeField("VACRCD", "VACRCD", JdeDataType.String, 6),
        new JdeField("VADGJ", "VADGJ", JdeDataType.Numeric),
        new JdeField("VADIVJ", "VADIVJ", JdeDataType.Numeric),
        new JdeField("VASTAM", "VASTAM", JdeDataType.Numeric),
        new JdeField("VAAAP", "VAAAP", JdeDataType.Numeric),
        new JdeField("VACTAM", "VACTAM", JdeDataType.Numeric),
        new JdeField("VAFOPN", "VAFOPN", JdeDataType.Numeric),
        new JdeField("VATXR1", "VATXR1", JdeDataType.Numeric),
        new JdeField("VATXR2", "VATXR2", JdeDataType.Numeric),
        new JdeField("VATXR3", "VATXR3", JdeDataType.Numeric),
        new JdeField("VATXR4", "VATXR4", JdeDataType.Numeric),
        new JdeField("VATXR5", "VATXR5", JdeDataType.Numeric),
        new JdeField("VAK70MTHD", "VAK70MTHD", JdeDataType.String, 2),
        new JdeField("VAK70VSTA", "VAK70VSTA", JdeDataType.String, 2),
        new JdeField("VAUSER", "VAUSER", JdeDataType.String, 20),
        new JdeField("VAPID", "VAPID", JdeDataType.String, 20),
        new JdeField("VAJOBN", "VAJOBN", JdeDataType.String, 20),
        new JdeField("VAUPMJ", "VAUPMJ", JdeDataType.Numeric),
        new JdeField("VAUPMT", "VAUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F704100_0", "Primary Key on VAKCO, VADCT, VADOC, VASFX, VASFXE, VAGL01", new[] { "VAKCO", "VADCT", "VADOC", "VASFX", "VASFXE", "VAGL01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F704100_2", "Index on VAICU, VAICUT", new[] { "VAICU", "VAICUT" })
    };
}
