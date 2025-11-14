using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A72 - .
/// </summary>
public class F79A72 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OM79AGHMID.
        /// </summary>
        public const string OM79AGHMID = "OM79AGHMID";

        /// <summary>
        /// OM79AGHID.
        /// </summary>
        public const string OM79AGHID = "OM79AGHID";

        /// <summary>
        /// OM79AGOPID.
        /// </summary>
        public const string OM79AGOPID = "OM79AGOPID";

        /// <summary>
        /// OM79AGOCID.
        /// </summary>
        public const string OM79AGOCID = "OM79AGOCID";

        /// <summary>
        /// OMPID.
        /// </summary>
        public const string OMPID = "OMPID";

        /// <summary>
        /// OMUSER.
        /// </summary>
        public const string OMUSER = "OMUSER";

        /// <summary>
        /// OMJOBN.
        /// </summary>
        public const string OMJOBN = "OMJOBN";

        /// <summary>
        /// OMUPMJ.
        /// </summary>
        public const string OMUPMJ = "OMUPMJ";

        /// <summary>
        /// OMTDAY.
        /// </summary>
        public const string OMTDAY = "OMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F79A72";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OM79AGHMID", "OM79AGHMID", JdeDataType.Numeric, null, true, true),
        new JdeField("OM79AGHID", "OM79AGHID", JdeDataType.Numeric),
        new JdeField("OM79AGOPID", "OM79AGOPID", JdeDataType.Numeric),
        new JdeField("OM79AGOCID", "OM79AGOCID", JdeDataType.Numeric),
        new JdeField("OMPID", "OMPID", JdeDataType.String, 20),
        new JdeField("OMUSER", "OMUSER", JdeDataType.String, 20),
        new JdeField("OMJOBN", "OMJOBN", JdeDataType.String, 20),
        new JdeField("OMUPMJ", "OMUPMJ", JdeDataType.Numeric),
        new JdeField("OMTDAY", "OMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A72_0", "Primary Key on OM79AGHMID", new[] { "OM79AGHMID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A72_2", "Unique Index on OM79AGHID, OM79AGOPID, OM79AGOCID", new[] { "OM79AGHID", "OM79AGOPID", "OM79AGOCID" }, isUnique: true),
        new JdeIndex("F79A72_3", "Index on OM79AGOCID, OM79AGHID, OM79AGOPID", new[] { "OM79AGOCID", "OM79AGHID", "OM79AGOPID" }),
        new JdeIndex("F79A72_4", "Index on OM79AGHID, OM79AGOCID", new[] { "OM79AGHID", "OM79AGOCID" }),
        new JdeIndex("F79A72_5", "Index on OM79AGOPID, OM79AGHID, OM79AGOCID", new[] { "OM79AGOPID", "OM79AGHID", "OM79AGOCID" })
    };
}
