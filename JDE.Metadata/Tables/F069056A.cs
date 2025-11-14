using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F069056A - .
/// </summary>
public class F069056A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// YOMCU.
        /// </summary>
        public const string YOMCU = "YOMCU";

        /// <summary>
        /// YOFCJ.
        /// </summary>
        public const string YOFCJ = "YOFCJ";

        /// <summary>
        /// YOSPACUSA1.
        /// </summary>
        public const string YOSPACUSA1 = "YOSPACUSA1";

        /// <summary>
        /// YOSPACUSA2.
        /// </summary>
        public const string YOSPACUSA2 = "YOSPACUSA2";

        /// <summary>
        /// YOSPACUSA3.
        /// </summary>
        public const string YOSPACUSA3 = "YOSPACUSA3";

        /// <summary>
        /// YOSPACUSA4.
        /// </summary>
        public const string YOSPACUSA4 = "YOSPACUSA4";

        /// <summary>
        /// YOSPADUSA1.
        /// </summary>
        public const string YOSPADUSA1 = "YOSPADUSA1";

        /// <summary>
        /// YOSPADUSA2.
        /// </summary>
        public const string YOSPADUSA2 = "YOSPADUSA2";

        /// <summary>
        /// YOSPADUSA3.
        /// </summary>
        public const string YOSPADUSA3 = "YOSPADUSA3";

        /// <summary>
        /// YOSPADUSA4.
        /// </summary>
        public const string YOSPADUSA4 = "YOSPADUSA4";

        /// <summary>
        /// YOSPANUSA1.
        /// </summary>
        public const string YOSPANUSA1 = "YOSPANUSA1";

        /// <summary>
        /// YOSPANUSA2.
        /// </summary>
        public const string YOSPANUSA2 = "YOSPANUSA2";

        /// <summary>
        /// YOSPANUSA3.
        /// </summary>
        public const string YOSPANUSA3 = "YOSPANUSA3";

        /// <summary>
        /// YOSPANUSA4.
        /// </summary>
        public const string YOSPANUSA4 = "YOSPANUSA4";

        /// <summary>
        /// YOSPASUSA1.
        /// </summary>
        public const string YOSPASUSA1 = "YOSPASUSA1";

        /// <summary>
        /// YOSPASUSA2.
        /// </summary>
        public const string YOSPASUSA2 = "YOSPASUSA2";

        /// <summary>
        /// YOSPASUSA3.
        /// </summary>
        public const string YOSPASUSA3 = "YOSPASUSA3";

        /// <summary>
        /// YOSPASUSA4.
        /// </summary>
        public const string YOSPASUSA4 = "YOSPASUSA4";

        /// <summary>
        /// YOPID.
        /// </summary>
        public const string YOPID = "YOPID";

        /// <summary>
        /// YOUSER.
        /// </summary>
        public const string YOUSER = "YOUSER";

        /// <summary>
        /// YOJOBN.
        /// </summary>
        public const string YOJOBN = "YOJOBN";

        /// <summary>
        /// YOUPMJ.
        /// </summary>
        public const string YOUPMJ = "YOUPMJ";

        /// <summary>
        /// YOUPMT.
        /// </summary>
        public const string YOUPMT = "YOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F069056A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("YOMCU", "YOMCU", JdeDataType.String, 24, true, true),
        new JdeField("YOFCJ", "YOFCJ", JdeDataType.String, 2),
        new JdeField("YOSPACUSA1", "YOSPACUSA1", JdeDataType.String, 2),
        new JdeField("YOSPACUSA2", "YOSPACUSA2", JdeDataType.String, 2),
        new JdeField("YOSPACUSA3", "YOSPACUSA3", JdeDataType.String, 2),
        new JdeField("YOSPACUSA4", "YOSPACUSA4", JdeDataType.String, 2),
        new JdeField("YOSPADUSA1", "YOSPADUSA1", JdeDataType.Numeric),
        new JdeField("YOSPADUSA2", "YOSPADUSA2", JdeDataType.Numeric),
        new JdeField("YOSPADUSA3", "YOSPADUSA3", JdeDataType.Numeric),
        new JdeField("YOSPADUSA4", "YOSPADUSA4", JdeDataType.Numeric),
        new JdeField("YOSPANUSA1", "YOSPANUSA1", JdeDataType.Numeric),
        new JdeField("YOSPANUSA2", "YOSPANUSA2", JdeDataType.Numeric),
        new JdeField("YOSPANUSA3", "YOSPANUSA3", JdeDataType.Numeric),
        new JdeField("YOSPANUSA4", "YOSPANUSA4", JdeDataType.Numeric),
        new JdeField("YOSPASUSA1", "YOSPASUSA1", JdeDataType.String, 60),
        new JdeField("YOSPASUSA2", "YOSPASUSA2", JdeDataType.String, 60),
        new JdeField("YOSPASUSA3", "YOSPASUSA3", JdeDataType.String, 60),
        new JdeField("YOSPASUSA4", "YOSPASUSA4", JdeDataType.String, 60),
        new JdeField("YOPID", "YOPID", JdeDataType.String, 20),
        new JdeField("YOUSER", "YOUSER", JdeDataType.String, 20),
        new JdeField("YOJOBN", "YOJOBN", JdeDataType.String, 20),
        new JdeField("YOUPMJ", "YOUPMJ", JdeDataType.Numeric),
        new JdeField("YOUPMT", "YOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F069056A_0", "Primary Key on YOMCU", new[] { "YOMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
