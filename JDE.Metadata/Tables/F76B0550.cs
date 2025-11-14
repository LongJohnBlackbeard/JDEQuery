using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B0550 - .
/// </summary>
public class F76B0550 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BCJOBS.
        /// </summary>
        public const string BCJOBS = "BCJOBS";

        /// <summary>
        /// BCUSER.
        /// </summary>
        public const string BCUSER = "BCUSER";

        /// <summary>
        /// BCBRANFK.
        /// </summary>
        public const string BCBRANFK = "BCBRANFK";

        /// <summary>
        /// BCLNID.
        /// </summary>
        public const string BCLNID = "BCLNID";

        /// <summary>
        /// BCBNNF.
        /// </summary>
        public const string BCBNNF = "BCBNNF";

        /// <summary>
        /// BCBSER.
        /// </summary>
        public const string BCBSER = "BCBSER";

        /// <summary>
        /// BCN001.
        /// </summary>
        public const string BCN001 = "BCN001";

        /// <summary>
        /// BCDCT.
        /// </summary>
        public const string BCDCT = "BCDCT";

        /// <summary>
        /// BCBRNOP.
        /// </summary>
        public const string BCBRNOP = "BCBRNOP";

        /// <summary>
        /// BCBRAAIC.
        /// </summary>
        public const string BCBRAAIC = "BCBRAAIC";

        /// <summary>
        /// BCBORI.
        /// </summary>
        public const string BCBORI = "BCBORI";
    }

    /// <inheritdoc />
    public override string TableName => "F76B0550";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BCJOBS", "BCJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("BCUSER", "BCUSER", JdeDataType.String, 20, true, true),
        new JdeField("BCBRANFK", "BCBRANFK", JdeDataType.Numeric, null, true, true),
        new JdeField("BCLNID", "BCLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("BCBNNF", "BCBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("BCBSER", "BCBSER", JdeDataType.String, 4, true, true),
        new JdeField("BCN001", "BCN001", JdeDataType.Numeric, null, true, true),
        new JdeField("BCDCT", "BCDCT", JdeDataType.String, 4, true, true),
        new JdeField("BCBRNOP", "BCBRNOP", JdeDataType.String, 10),
        new JdeField("BCBRAAIC", "BCBRAAIC", JdeDataType.Numeric),
        new JdeField("BCBORI", "BCBORI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B0550_0", "Primary Key on BCJOBS, BCUSER, BCBRANFK, BCLNID, BCBNNF, BCBSER, BCN001, BCDCT", new[] { "BCJOBS", "BCUSER", "BCBRANFK", "BCLNID", "BCBNNF", "BCBSER", "BCN001", "BCDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
