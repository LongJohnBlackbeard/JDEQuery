using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74U0451 - .
/// </summary>
public class F74U0451 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCUKADDN.
        /// </summary>
        public const string SCUKADDN = "SCUKADDN";

        /// <summary>
        /// SCUKSPANN.
        /// </summary>
        public const string SCUKSPANN = "SCUKSPANN";

        /// <summary>
        /// SCUKSPT.
        /// </summary>
        public const string SCUKSPT = "SCUKSPT";

        /// <summary>
        /// SCUKSPCAT1.
        /// </summary>
        public const string SCUKSPCAT1 = "SCUKSPCAT1";

        /// <summary>
        /// SCUKSPCAT3.
        /// </summary>
        public const string SCUKSPCAT3 = "SCUKSPCAT3";

        /// <summary>
        /// SCURCD.
        /// </summary>
        public const string SCURCD = "SCURCD";

        /// <summary>
        /// SCURAT.
        /// </summary>
        public const string SCURAT = "SCURAT";

        /// <summary>
        /// SCURAB.
        /// </summary>
        public const string SCURAB = "SCURAB";

        /// <summary>
        /// SCURRF.
        /// </summary>
        public const string SCURRF = "SCURRF";

        /// <summary>
        /// SCURDT.
        /// </summary>
        public const string SCURDT = "SCURDT";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUPMT.
        /// </summary>
        public const string SCUPMT = "SCUPMT";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F74U0451";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCUKADDN", "SCUKADDN", JdeDataType.Numeric, null, true, true),
        new JdeField("SCUKSPANN", "SCUKSPANN", JdeDataType.Numeric, null, true, true),
        new JdeField("SCUKSPT", "SCUKSPT", JdeDataType.String, 2),
        new JdeField("SCUKSPCAT1", "SCUKSPCAT1", JdeDataType.String, 6),
        new JdeField("SCUKSPCAT3", "SCUKSPCAT3", JdeDataType.String, 20),
        new JdeField("SCURCD", "SCURCD", JdeDataType.String, 4),
        new JdeField("SCURAT", "SCURAT", JdeDataType.Numeric),
        new JdeField("SCURAB", "SCURAB", JdeDataType.Numeric),
        new JdeField("SCURRF", "SCURRF", JdeDataType.String, 30),
        new JdeField("SCURDT", "SCURDT", JdeDataType.Numeric),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMT", "SCUPMT", JdeDataType.Numeric),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74U0451_0", "Primary Key on SCUKADDN, SCUKSPANN", new[] { "SCUKADDN", "SCUKSPANN" }, isUnique: true, isPrimaryKey: true)
    };
}
