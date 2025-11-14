using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76H3B5Z - .
/// </summary>
public class F76H3B5Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IREDUS.
        /// </summary>
        public const string IREDUS = "IREDUS";

        /// <summary>
        /// IREDTN.
        /// </summary>
        public const string IREDTN = "IREDTN";

        /// <summary>
        /// IREDBT.
        /// </summary>
        public const string IREDBT = "IREDBT";

        /// <summary>
        /// IREDLN.
        /// </summary>
        public const string IREDLN = "IREDLN";

        /// <summary>
        /// IRH76LECO.
        /// </summary>
        public const string IRH76LECO = "IRH76LECO";

        /// <summary>
        /// IRH76LEDT.
        /// </summary>
        public const string IRH76LEDT = "IRH76LEDT";

        /// <summary>
        /// IRH76EMS.
        /// </summary>
        public const string IRH76EMS = "IRH76EMS";

        /// <summary>
        /// IRH76LENU.
        /// </summary>
        public const string IRH76LENU = "IRH76LENU";

        /// <summary>
        /// IRH76FUC.
        /// </summary>
        public const string IRH76FUC = "IRH76FUC";

        /// <summary>
        /// IRH76FUD.
        /// </summary>
        public const string IRH76FUD = "IRH76FUD";

        /// <summary>
        /// IRH76FUR.
        /// </summary>
        public const string IRH76FUR = "IRH76FUR";

        /// <summary>
        /// IRH76FUA.
        /// </summary>
        public const string IRH76FUA = "IRH76FUA";

        /// <summary>
        /// IRH76FUF.
        /// </summary>
        public const string IRH76FUF = "IRH76FUF";

        /// <summary>
        /// IRUSER.
        /// </summary>
        public const string IRUSER = "IRUSER";

        /// <summary>
        /// IRPID.
        /// </summary>
        public const string IRPID = "IRPID";

        /// <summary>
        /// IRJOBN.
        /// </summary>
        public const string IRJOBN = "IRJOBN";

        /// <summary>
        /// IRUPMJ.
        /// </summary>
        public const string IRUPMJ = "IRUPMJ";

        /// <summary>
        /// IRUPMT.
        /// </summary>
        public const string IRUPMT = "IRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76H3B5Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IREDUS", "IREDUS", JdeDataType.String, 20, true, true),
        new JdeField("IREDTN", "IREDTN", JdeDataType.String, 44, true, true),
        new JdeField("IREDBT", "IREDBT", JdeDataType.String, 30, true, true),
        new JdeField("IREDLN", "IREDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("IRH76LECO", "IRH76LECO", JdeDataType.String, 10),
        new JdeField("IRH76LEDT", "IRH76LEDT", JdeDataType.String, 6),
        new JdeField("IRH76EMS", "IRH76EMS", JdeDataType.String, 8),
        new JdeField("IRH76LENU", "IRH76LENU", JdeDataType.Numeric),
        new JdeField("IRH76FUC", "IRH76FUC", JdeDataType.String, 20),
        new JdeField("IRH76FUD", "IRH76FUD", JdeDataType.Numeric),
        new JdeField("IRH76FUR", "IRH76FUR", JdeDataType.String, 30),
        new JdeField("IRH76FUA", "IRH76FUA", JdeDataType.Numeric),
        new JdeField("IRH76FUF", "IRH76FUF", JdeDataType.String, 2),
        new JdeField("IRUSER", "IRUSER", JdeDataType.String, 20),
        new JdeField("IRPID", "IRPID", JdeDataType.String, 20),
        new JdeField("IRJOBN", "IRJOBN", JdeDataType.String, 20),
        new JdeField("IRUPMJ", "IRUPMJ", JdeDataType.Numeric),
        new JdeField("IRUPMT", "IRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76H3B5Z_0", "Primary Key on IREDUS, IREDTN, IREDBT, IREDLN", new[] { "IREDUS", "IREDTN", "IREDBT", "IREDLN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76H3B5Z_4", "Index on IRH76LECO, IRH76LEDT, IRH76EMS, IRH76LENU", new[] { "IRH76LECO", "IRH76LEDT", "IRH76EMS", "IRH76LENU" })
    };
}
