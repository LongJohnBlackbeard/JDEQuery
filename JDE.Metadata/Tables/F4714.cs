using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4714 - .
/// </summary>
public class F4714 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZTEDTY.
        /// </summary>
        public const string ZTEDTY = "ZTEDTY";

        /// <summary>
        /// ZTEDSQ.
        /// </summary>
        public const string ZTEDSQ = "ZTEDSQ";

        /// <summary>
        /// ZTEKCO.
        /// </summary>
        public const string ZTEKCO = "ZTEKCO";

        /// <summary>
        /// ZTEDOC.
        /// </summary>
        public const string ZTEDOC = "ZTEDOC";

        /// <summary>
        /// ZTEDCT.
        /// </summary>
        public const string ZTEDCT = "ZTEDCT";

        /// <summary>
        /// ZTEDLN.
        /// </summary>
        public const string ZTEDLN = "ZTEDLN";

        /// <summary>
        /// ZTEDSP.
        /// </summary>
        public const string ZTEDSP = "ZTEDSP";

        /// <summary>
        /// ZTEDBT.
        /// </summary>
        public const string ZTEDBT = "ZTEDBT";

        /// <summary>
        /// ZTFILE.
        /// </summary>
        public const string ZTFILE = "ZTFILE";

        /// <summary>
        /// ZTKCOO.
        /// </summary>
        public const string ZTKCOO = "ZTKCOO";

        /// <summary>
        /// ZTDOCO.
        /// </summary>
        public const string ZTDOCO = "ZTDOCO";

        /// <summary>
        /// ZTDCTO.
        /// </summary>
        public const string ZTDCTO = "ZTDCTO";

        /// <summary>
        /// ZTLNID.
        /// </summary>
        public const string ZTLNID = "ZTLNID";

        /// <summary>
        /// ZTPNTC.
        /// </summary>
        public const string ZTPNTC = "ZTPNTC";

        /// <summary>
        /// ZTLINS.
        /// </summary>
        public const string ZTLINS = "ZTLINS";

        /// <summary>
        /// ZTTXLN.
        /// </summary>
        public const string ZTTXLN = "ZTTXLN";

        /// <summary>
        /// ZTTORG.
        /// </summary>
        public const string ZTTORG = "ZTTORG";

        /// <summary>
        /// ZTUSER.
        /// </summary>
        public const string ZTUSER = "ZTUSER";

        /// <summary>
        /// ZTPID.
        /// </summary>
        public const string ZTPID = "ZTPID";

        /// <summary>
        /// ZTJOBN.
        /// </summary>
        public const string ZTJOBN = "ZTJOBN";

        /// <summary>
        /// ZTUPMJ.
        /// </summary>
        public const string ZTUPMJ = "ZTUPMJ";

        /// <summary>
        /// ZTTDAY.
        /// </summary>
        public const string ZTTDAY = "ZTTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4714";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZTEDTY", "ZTEDTY", JdeDataType.String, 2),
        new JdeField("ZTEDSQ", "ZTEDSQ", JdeDataType.Numeric),
        new JdeField("ZTEKCO", "ZTEKCO", JdeDataType.String, 10, true, true),
        new JdeField("ZTEDOC", "ZTEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ZTEDCT", "ZTEDCT", JdeDataType.String, 4, true, true),
        new JdeField("ZTEDLN", "ZTEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZTEDSP", "ZTEDSP", JdeDataType.String, 2),
        new JdeField("ZTEDBT", "ZTEDBT", JdeDataType.String, 30),
        new JdeField("ZTFILE", "ZTFILE", JdeDataType.String, 20, true, true),
        new JdeField("ZTKCOO", "ZTKCOO", JdeDataType.String, 10),
        new JdeField("ZTDOCO", "ZTDOCO", JdeDataType.Numeric),
        new JdeField("ZTDCTO", "ZTDCTO", JdeDataType.String, 4),
        new JdeField("ZTLNID", "ZTLNID", JdeDataType.Numeric),
        new JdeField("ZTPNTC", "ZTPNTC", JdeDataType.String, 2),
        new JdeField("ZTLINS", "ZTLINS", JdeDataType.Numeric, null, true, true),
        new JdeField("ZTTXLN", "ZTTXLN", JdeDataType.String, 120),
        new JdeField("ZTTORG", "ZTTORG", JdeDataType.String, 20),
        new JdeField("ZTUSER", "ZTUSER", JdeDataType.String, 20),
        new JdeField("ZTPID", "ZTPID", JdeDataType.String, 20),
        new JdeField("ZTJOBN", "ZTJOBN", JdeDataType.String, 20),
        new JdeField("ZTUPMJ", "ZTUPMJ", JdeDataType.Numeric),
        new JdeField("ZTTDAY", "ZTTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4714_0", "Primary Key on ZTFILE, ZTEDOC, ZTEDCT, ZTEKCO, ZTEDLN, ZTLINS", new[] { "ZTFILE", "ZTEDOC", "ZTEDCT", "ZTEKCO", "ZTEDLN", "ZTLINS" }, isUnique: true, isPrimaryKey: true)
    };
}
