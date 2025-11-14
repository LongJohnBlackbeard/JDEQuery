using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47500WF - .
/// </summary>
public class F47500WF : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SZEKCO.
        /// </summary>
        public const string SZEKCO = "SZEKCO";

        /// <summary>
        /// SZEDOC.
        /// </summary>
        public const string SZEDOC = "SZEDOC";

        /// <summary>
        /// SZEDCT.
        /// </summary>
        public const string SZEDCT = "SZEDCT";

        /// <summary>
        /// SZUKID.
        /// </summary>
        public const string SZUKID = "SZUKID";

        /// <summary>
        /// SZUSER.
        /// </summary>
        public const string SZUSER = "SZUSER";

        /// <summary>
        /// SZPID.
        /// </summary>
        public const string SZPID = "SZPID";

        /// <summary>
        /// SZJOBN.
        /// </summary>
        public const string SZJOBN = "SZJOBN";

        /// <summary>
        /// SZUPMJ.
        /// </summary>
        public const string SZUPMJ = "SZUPMJ";

        /// <summary>
        /// SZTDAY.
        /// </summary>
        public const string SZTDAY = "SZTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47500WF";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEKCO", "SZEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SZEDOC", "SZEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SZUKID", "SZUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47500WF_0", "Primary Key on SZEKCO, SZEDOC, SZEDCT, SZUKID", new[] { "SZEKCO", "SZEDOC", "SZEDCT", "SZUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
