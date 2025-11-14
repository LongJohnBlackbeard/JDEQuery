using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L30 - .
/// </summary>
public class F46L30 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCMCU.
        /// </summary>
        public const string LCMCU = "LCMCU";

        /// <summary>
        /// LCLOCN.
        /// </summary>
        public const string LCLOCN = "LCLOCN";

        /// <summary>
        /// LCUCUB.
        /// </summary>
        public const string LCUCUB = "LCUCUB";

        /// <summary>
        /// LCMAXLCV.
        /// </summary>
        public const string LCMAXLCV = "LCMAXLCV";

        /// <summary>
        /// LCRSLCV.
        /// </summary>
        public const string LCRSLCV = "LCRSLCV";

        /// <summary>
        /// LCLNCS.
        /// </summary>
        public const string LCLNCS = "LCLNCS";

        /// <summary>
        /// LCVUMD.
        /// </summary>
        public const string LCVUMD = "LCVUMD";

        /// <summary>
        /// LCULWEI.
        /// </summary>
        public const string LCULWEI = "LCULWEI";

        /// <summary>
        /// LCMAXW.
        /// </summary>
        public const string LCMAXW = "LCMAXW";

        /// <summary>
        /// LCRLWEI.
        /// </summary>
        public const string LCRLWEI = "LCRLWEI";

        /// <summary>
        /// LCUWUM.
        /// </summary>
        public const string LCUWUM = "LCUWUM";

        /// <summary>
        /// LCURAT.
        /// </summary>
        public const string LCURAT = "LCURAT";

        /// <summary>
        /// LCURAB.
        /// </summary>
        public const string LCURAB = "LCURAB";

        /// <summary>
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";

        /// <summary>
        /// LCUTIME.
        /// </summary>
        public const string LCUTIME = "LCUTIME";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCSVRNAME.
        /// </summary>
        public const string LCSVRNAME = "LCSVRNAME";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCMKEY.
        /// </summary>
        public const string LCMKEY = "LCMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F46L30";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCMCU", "LCMCU", JdeDataType.String, 24, true, true),
        new JdeField("LCLOCN", "LCLOCN", JdeDataType.String, 40, true, true),
        new JdeField("LCUCUB", "LCUCUB", JdeDataType.Numeric),
        new JdeField("LCMAXLCV", "LCMAXLCV", JdeDataType.Numeric),
        new JdeField("LCRSLCV", "LCRSLCV", JdeDataType.Numeric),
        new JdeField("LCLNCS", "LCLNCS", JdeDataType.String, 10),
        new JdeField("LCVUMD", "LCVUMD", JdeDataType.String, 4),
        new JdeField("LCULWEI", "LCULWEI", JdeDataType.Numeric),
        new JdeField("LCMAXW", "LCMAXW", JdeDataType.Numeric),
        new JdeField("LCRLWEI", "LCRLWEI", JdeDataType.Numeric),
        new JdeField("LCUWUM", "LCUWUM", JdeDataType.String, 4),
        new JdeField("LCURAT", "LCURAT", JdeDataType.Numeric),
        new JdeField("LCURAB", "LCURAB", JdeDataType.Numeric),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30),
        new JdeField("LCUTIME", "LCUTIME", JdeDataType.Date),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCSVRNAME", "LCSVRNAME", JdeDataType.String, 30),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCMKEY", "LCMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L30_0", "Primary Key on LCMCU, LCLOCN", new[] { "LCMCU", "LCLOCN" }, isUnique: true, isPrimaryKey: true)
    };
}
