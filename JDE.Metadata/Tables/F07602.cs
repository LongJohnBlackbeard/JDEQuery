using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07602 - .
/// </summary>
public class F07602 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LRLVVS.
        /// </summary>
        public const string LRLVVS = "LRLVVS";

        /// <summary>
        /// LRLRSEGN.
        /// </summary>
        public const string LRLRSEGN = "LRLRSEGN";

        /// <summary>
        /// LRLRSEGID.
        /// </summary>
        public const string LRLRSEGID = "LRLRSEGID";

        /// <summary>
        /// LRLTTP.
        /// </summary>
        public const string LRLTTP = "LRLTTP";

        /// <summary>
        /// LRAVBL.
        /// </summary>
        public const string LRAVBL = "LRAVBL";

        /// <summary>
        /// LRLVPD.
        /// </summary>
        public const string LRLVPD = "LRLVPD";

        /// <summary>
        /// LRSCKR.
        /// </summary>
        public const string LRSCKR = "LRSCKR";

        /// <summary>
        /// LRSCTD.
        /// </summary>
        public const string LRSCTD = "LRSCTD";

        /// <summary>
        /// LRSCCX.
        /// </summary>
        public const string LRSCCX = "LRSCCX";

        /// <summary>
        /// LRSEVD.
        /// </summary>
        public const string LRSEVD = "LRSEVD";

        /// <summary>
        /// LRSEPD.
        /// </summary>
        public const string LRSEPD = "LRSEPD";

        /// <summary>
        /// LRSEPM.
        /// </summary>
        public const string LRSEPM = "LRSEPM";

        /// <summary>
        /// LRSEHD.
        /// </summary>
        public const string LRSEHD = "LRSEHD";

        /// <summary>
        /// LRLVAV.
        /// </summary>
        public const string LRLVAV = "LRLVAV";

        /// <summary>
        /// LRLPIA.
        /// </summary>
        public const string LRLPIA = "LRLPIA";
    }

    /// <inheritdoc />
    public override string TableName => "F07602";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LRLVVS", "LRLVVS", JdeDataType.String, 20, true, true),
        new JdeField("LRLRSEGN", "LRLRSEGN", JdeDataType.String, 60, true, true),
        new JdeField("LRLRSEGID", "LRLRSEGID", JdeDataType.Numeric, null, true, true),
        new JdeField("LRLTTP", "LRLTTP", JdeDataType.String, 4, true, true),
        new JdeField("LRAVBL", "LRAVBL", JdeDataType.String, 2),
        new JdeField("LRLVPD", "LRLVPD", JdeDataType.String, 2),
        new JdeField("LRSCKR", "LRSCKR", JdeDataType.String, 4),
        new JdeField("LRSCTD", "LRSCTD", JdeDataType.Numeric),
        new JdeField("LRSCCX", "LRSCCX", JdeDataType.Numeric),
        new JdeField("LRSEVD", "LRSEVD", JdeDataType.String, 2),
        new JdeField("LRSEPD", "LRSEPD", JdeDataType.String, 2),
        new JdeField("LRSEPM", "LRSEPM", JdeDataType.Numeric),
        new JdeField("LRSEHD", "LRSEHD", JdeDataType.Numeric),
        new JdeField("LRLVAV", "LRLVAV", JdeDataType.String, 60),
        new JdeField("LRLPIA", "LRLPIA", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07602_0", "Primary Key on LRLVVS, LRLRSEGN, LRLRSEGID, LRLTTP", new[] { "LRLVVS", "LRLRSEGN", "LRLRSEGID", "LRLTTP" }, isUnique: true, isPrimaryKey: true)
    };
}
