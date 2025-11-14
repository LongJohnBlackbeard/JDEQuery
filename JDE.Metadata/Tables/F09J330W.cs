using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J330W - .
/// </summary>
public class F09J330W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JAUKID.
        /// </summary>
        public const string JAUKID = "JAUKID";

        /// <summary>
        /// JAJVNAME.
        /// </summary>
        public const string JAJVNAME = "JAJVNAME";

        /// <summary>
        /// JAMCU.
        /// </summary>
        public const string JAMCU = "JAMCU";

        /// <summary>
        /// JAJVBUSTS.
        /// </summary>
        public const string JAJVBUSTS = "JAJVBUSTS";

        /// <summary>
        /// JAJVINDATE.
        /// </summary>
        public const string JAJVINDATE = "JAJVINDATE";

        /// <summary>
        /// JAEV01.
        /// </summary>
        public const string JAEV01 = "JAEV01";
    }

    /// <inheritdoc />
    public override string TableName => "F09J330W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JAUKID", "JAUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("JAJVNAME", "JAJVNAME", JdeDataType.String, 40, true, true),
        new JdeField("JAMCU", "JAMCU", JdeDataType.String, 24, true, true),
        new JdeField("JAJVBUSTS", "JAJVBUSTS", JdeDataType.String, 6),
        new JdeField("JAJVINDATE", "JAJVINDATE", JdeDataType.Numeric),
        new JdeField("JAEV01", "JAEV01", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J330W_0", "Primary Key on JAUKID, JAJVNAME, JAMCU", new[] { "JAUKID", "JAJVNAME", "JAMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
