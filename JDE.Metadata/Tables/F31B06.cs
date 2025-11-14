using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B06 - .
/// </summary>
public class F31B06 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WVMCU.
        /// </summary>
        public const string WVMCU = "WVMCU";

        /// <summary>
        /// WVVARID.
        /// </summary>
        public const string WVVARID = "WVVARID";

        /// <summary>
        /// WVMTUOM.
        /// </summary>
        public const string WVMTUOM = "WVMTUOM";

        /// <summary>
        /// WVRMTUOM.
        /// </summary>
        public const string WVRMTUOM = "WVRMTUOM";

        /// <summary>
        /// WVUMCF.
        /// </summary>
        public const string WVUMCF = "WVUMCF";

        /// <summary>
        /// WVCONL.
        /// </summary>
        public const string WVCONL = "WVCONL";

        /// <summary>
        /// WVPID.
        /// </summary>
        public const string WVPID = "WVPID";

        /// <summary>
        /// WVUSER.
        /// </summary>
        public const string WVUSER = "WVUSER";

        /// <summary>
        /// WVJOBN.
        /// </summary>
        public const string WVJOBN = "WVJOBN";

        /// <summary>
        /// WVUPMJ.
        /// </summary>
        public const string WVUPMJ = "WVUPMJ";

        /// <summary>
        /// WVUPMT.
        /// </summary>
        public const string WVUPMT = "WVUPMT";

        /// <summary>
        /// WVURCD.
        /// </summary>
        public const string WVURCD = "WVURCD";

        /// <summary>
        /// WVURDT.
        /// </summary>
        public const string WVURDT = "WVURDT";

        /// <summary>
        /// WVURAT.
        /// </summary>
        public const string WVURAT = "WVURAT";

        /// <summary>
        /// WVURAB.
        /// </summary>
        public const string WVURAB = "WVURAB";

        /// <summary>
        /// WVURRF.
        /// </summary>
        public const string WVURRF = "WVURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F31B06";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WVMCU", "WVMCU", JdeDataType.String, 24, true, true),
        new JdeField("WVVARID", "WVVARID", JdeDataType.Numeric, null, true, true),
        new JdeField("WVMTUOM", "WVMTUOM", JdeDataType.String, 4, true, true),
        new JdeField("WVRMTUOM", "WVRMTUOM", JdeDataType.String, 4, true, true),
        new JdeField("WVUMCF", "WVUMCF", JdeDataType.Numeric),
        new JdeField("WVCONL", "WVCONL", JdeDataType.String, 2),
        new JdeField("WVPID", "WVPID", JdeDataType.String, 20),
        new JdeField("WVUSER", "WVUSER", JdeDataType.String, 20),
        new JdeField("WVJOBN", "WVJOBN", JdeDataType.String, 20),
        new JdeField("WVUPMJ", "WVUPMJ", JdeDataType.Numeric),
        new JdeField("WVUPMT", "WVUPMT", JdeDataType.Numeric),
        new JdeField("WVURCD", "WVURCD", JdeDataType.String, 4),
        new JdeField("WVURDT", "WVURDT", JdeDataType.Numeric),
        new JdeField("WVURAT", "WVURAT", JdeDataType.Numeric),
        new JdeField("WVURAB", "WVURAB", JdeDataType.Numeric),
        new JdeField("WVURRF", "WVURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B06_0", "Primary Key on WVMCU, WVVARID, WVMTUOM, WVRMTUOM", new[] { "WVMCU", "WVVARID", "WVMTUOM", "WVRMTUOM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B06_3", "Index on WVVARID, WVMTUOM, WVRMTUOM", new[] { "WVVARID", "WVMTUOM", "WVRMTUOM" }),
        new JdeIndex("F31B06_4", "Index on WVMTUOM, WVRMTUOM", new[] { "WVMTUOM", "WVRMTUOM" })
    };
}
