using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08370 - .
/// </summary>
public class F08370 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// B7RSAY.
        /// </summary>
        public const string B7RSAY = "B7RSAY";

        /// <summary>
        /// B7AN8.
        /// </summary>
        public const string B7AN8 = "B7AN8";

        /// <summary>
        /// B7PLAN.
        /// </summary>
        public const string B7PLAN = "B7PLAN";

        /// <summary>
        /// B7SACC.
        /// </summary>
        public const string B7SACC = "B7SACC";

        /// <summary>
        /// B7PDBA.
        /// </summary>
        public const string B7PDBA = "B7PDBA";

        /// <summary>
        /// B7BOF.
        /// </summary>
        public const string B7BOF = "B7BOF";

        /// <summary>
        /// B7YTDC.
        /// </summary>
        public const string B7YTDC = "B7YTDC";

        /// <summary>
        /// B7YTDR.
        /// </summary>
        public const string B7YTDR = "B7YTDR";

        /// <summary>
        /// B7SADC.
        /// </summary>
        public const string B7SADC = "B7SADC";

        /// <summary>
        /// B7YTDB.
        /// </summary>
        public const string B7YTDB = "B7YTDB";

        /// <summary>
        /// B7YTDO.
        /// </summary>
        public const string B7YTDO = "B7YTDO";

        /// <summary>
        /// B7YTDY.
        /// </summary>
        public const string B7YTDY = "B7YTDY";

        /// <summary>
        /// B7YTDA.
        /// </summary>
        public const string B7YTDA = "B7YTDA";

        /// <summary>
        /// B7YTDD.
        /// </summary>
        public const string B7YTDD = "B7YTDD";

        /// <summary>
        /// B7YTDM.
        /// </summary>
        public const string B7YTDM = "B7YTDM";

        /// <summary>
        /// B7DPYN.
        /// </summary>
        public const string B7DPYN = "B7DPYN";

        /// <summary>
        /// B7USER.
        /// </summary>
        public const string B7USER = "B7USER";

        /// <summary>
        /// B7PID.
        /// </summary>
        public const string B7PID = "B7PID";

        /// <summary>
        /// B7JOBN.
        /// </summary>
        public const string B7JOBN = "B7JOBN";

        /// <summary>
        /// B7UPMJ.
        /// </summary>
        public const string B7UPMJ = "B7UPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F08370";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("B7RSAY", "B7RSAY", JdeDataType.Numeric, null, true, true),
        new JdeField("B7AN8", "B7AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("B7PLAN", "B7PLAN", JdeDataType.String, 16, true, true),
        new JdeField("B7SACC", "B7SACC", JdeDataType.String, 6),
        new JdeField("B7PDBA", "B7PDBA", JdeDataType.Numeric),
        new JdeField("B7BOF", "B7BOF", JdeDataType.Numeric),
        new JdeField("B7YTDC", "B7YTDC", JdeDataType.Numeric),
        new JdeField("B7YTDR", "B7YTDR", JdeDataType.Numeric),
        new JdeField("B7SADC", "B7SADC", JdeDataType.Numeric),
        new JdeField("B7YTDB", "B7YTDB", JdeDataType.Numeric),
        new JdeField("B7YTDO", "B7YTDO", JdeDataType.Numeric),
        new JdeField("B7YTDY", "B7YTDY", JdeDataType.Numeric),
        new JdeField("B7YTDA", "B7YTDA", JdeDataType.Numeric),
        new JdeField("B7YTDD", "B7YTDD", JdeDataType.Numeric),
        new JdeField("B7YTDM", "B7YTDM", JdeDataType.Numeric),
        new JdeField("B7DPYN", "B7DPYN", JdeDataType.String, 2),
        new JdeField("B7USER", "B7USER", JdeDataType.String, 20),
        new JdeField("B7PID", "B7PID", JdeDataType.String, 20),
        new JdeField("B7JOBN", "B7JOBN", JdeDataType.String, 20),
        new JdeField("B7UPMJ", "B7UPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08370_0", "Primary Key on B7RSAY, B7AN8, B7PLAN", new[] { "B7RSAY", "B7AN8", "B7PLAN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08370_2", "Index on B7RSAY, B7AN8, B7SACC", new[] { "B7RSAY", "B7AN8", "B7SACC" }),
        new JdeIndex("F08370_3", "Index on B7RSAY, B7PLAN, B7AN8", new[] { "B7RSAY", "B7PLAN", "B7AN8" })
    };
}
