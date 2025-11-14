using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76A8050 - .
/// </summary>
public class F76A8050 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PPAN8.
        /// </summary>
        public const string PPAN8 = "PPAN8";

        /// <summary>
        /// PPATXC.
        /// </summary>
        public const string PPATXC = "PPATXC";

        /// <summary>
        /// PPEFTJ.
        /// </summary>
        public const string PPEFTJ = "PPEFTJ";

        /// <summary>
        /// PPEFDJ.
        /// </summary>
        public const string PPEFDJ = "PPEFDJ";

        /// <summary>
        /// PPTXR1.
        /// </summary>
        public const string PPTXR1 = "PPTXR1";

        /// <summary>
        /// PPABD.
        /// </summary>
        public const string PPABD = "PPABD";

        /// <summary>
        /// PPURCD.
        /// </summary>
        public const string PPURCD = "PPURCD";

        /// <summary>
        /// PPURDT.
        /// </summary>
        public const string PPURDT = "PPURDT";

        /// <summary>
        /// PPURAT.
        /// </summary>
        public const string PPURAT = "PPURAT";

        /// <summary>
        /// PPURAB.
        /// </summary>
        public const string PPURAB = "PPURAB";

        /// <summary>
        /// PPURRF.
        /// </summary>
        public const string PPURRF = "PPURRF";

        /// <summary>
        /// PPTORG.
        /// </summary>
        public const string PPTORG = "PPTORG";

        /// <summary>
        /// PPUSER.
        /// </summary>
        public const string PPUSER = "PPUSER";

        /// <summary>
        /// PPPID.
        /// </summary>
        public const string PPPID = "PPPID";

        /// <summary>
        /// PPJOBN.
        /// </summary>
        public const string PPJOBN = "PPJOBN";

        /// <summary>
        /// PPUPMJ.
        /// </summary>
        public const string PPUPMJ = "PPUPMJ";

        /// <summary>
        /// PPTDAY.
        /// </summary>
        public const string PPTDAY = "PPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F76A8050";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PPAN8", "PPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PPATXC", "PPATXC", JdeDataType.String, 20, true, true),
        new JdeField("PPEFTJ", "PPEFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PPEFDJ", "PPEFDJ", JdeDataType.Numeric),
        new JdeField("PPTXR1", "PPTXR1", JdeDataType.Numeric),
        new JdeField("PPABD", "PPABD", JdeDataType.Numeric),
        new JdeField("PPURCD", "PPURCD", JdeDataType.String, 4),
        new JdeField("PPURDT", "PPURDT", JdeDataType.Numeric),
        new JdeField("PPURAT", "PPURAT", JdeDataType.Numeric),
        new JdeField("PPURAB", "PPURAB", JdeDataType.Numeric),
        new JdeField("PPURRF", "PPURRF", JdeDataType.String, 30),
        new JdeField("PPTORG", "PPTORG", JdeDataType.String, 20),
        new JdeField("PPUSER", "PPUSER", JdeDataType.String, 20),
        new JdeField("PPPID", "PPPID", JdeDataType.String, 20),
        new JdeField("PPJOBN", "PPJOBN", JdeDataType.String, 20),
        new JdeField("PPUPMJ", "PPUPMJ", JdeDataType.Numeric),
        new JdeField("PPTDAY", "PPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76A8050_0", "Primary Key on PPAN8, PPATXC, PPEFTJ", new[] { "PPAN8", "PPATXC", "PPEFTJ" }, isUnique: true, isPrimaryKey: true)
    };
}
