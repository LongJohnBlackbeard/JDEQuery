using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F37011 - .
/// </summary>
public class F37011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TEMCU.
        /// </summary>
        public const string TEMCU = "TEMCU";

        /// <summary>
        /// TEQTST.
        /// </summary>
        public const string TEQTST = "TEQTST";

        /// <summary>
        /// TENUMB.
        /// </summary>
        public const string TENUMB = "TENUMB";

        /// <summary>
        /// TEURCD.
        /// </summary>
        public const string TEURCD = "TEURCD";

        /// <summary>
        /// TEURAT.
        /// </summary>
        public const string TEURAT = "TEURAT";

        /// <summary>
        /// TEURRF.
        /// </summary>
        public const string TEURRF = "TEURRF";

        /// <summary>
        /// TEURAB.
        /// </summary>
        public const string TEURAB = "TEURAB";

        /// <summary>
        /// TEUSER.
        /// </summary>
        public const string TEUSER = "TEUSER";

        /// <summary>
        /// TEPID.
        /// </summary>
        public const string TEPID = "TEPID";

        /// <summary>
        /// TEUPMJ.
        /// </summary>
        public const string TEUPMJ = "TEUPMJ";

        /// <summary>
        /// TETDAY.
        /// </summary>
        public const string TETDAY = "TETDAY";

        /// <summary>
        /// TEPRODF.
        /// </summary>
        public const string TEPRODF = "TEPRODF";

        /// <summary>
        /// TEPRODM.
        /// </summary>
        public const string TEPRODM = "TEPRODM";
    }

    /// <inheritdoc />
    public override string TableName => "F37011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TEMCU", "TEMCU", JdeDataType.String, 24, true, true),
        new JdeField("TEQTST", "TEQTST", JdeDataType.String, 50, true, true),
        new JdeField("TENUMB", "TENUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("TEURCD", "TEURCD", JdeDataType.String, 4),
        new JdeField("TEURAT", "TEURAT", JdeDataType.Numeric),
        new JdeField("TEURRF", "TEURRF", JdeDataType.String, 30),
        new JdeField("TEURAB", "TEURAB", JdeDataType.Numeric),
        new JdeField("TEUSER", "TEUSER", JdeDataType.String, 20),
        new JdeField("TEPID", "TEPID", JdeDataType.String, 20),
        new JdeField("TEUPMJ", "TEUPMJ", JdeDataType.Numeric),
        new JdeField("TETDAY", "TETDAY", JdeDataType.Numeric),
        new JdeField("TEPRODF", "TEPRODF", JdeDataType.String, 16),
        new JdeField("TEPRODM", "TEPRODM", JdeDataType.String, 16)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F37011_0", "Primary Key on TEMCU, TEQTST, TENUMB", new[] { "TEMCU", "TEQTST", "TENUMB" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F37011_2", "Index on TEMCU, TENUMB", new[] { "TEMCU", "TENUMB" })
    };
}
