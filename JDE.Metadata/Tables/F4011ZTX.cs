using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4011ZTX - .
/// </summary>
public class F4011ZTX : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
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
        /// ZTTUPRC.
        /// </summary>
        public const string ZTTUPRC = "ZTTUPRC";

        /// <summary>
        /// ZTUTA.
        /// </summary>
        public const string ZTUTA = "ZTUTA";

        /// <summary>
        /// ZTTAEXP.
        /// </summary>
        public const string ZTTAEXP = "ZTTAEXP";

        /// <summary>
        /// ZTETA.
        /// </summary>
        public const string ZTETA = "ZTETA";

        /// <summary>
        /// ZTTFUP.
        /// </summary>
        public const string ZTTFUP = "ZTTFUP";

        /// <summary>
        /// ZTFUTA.
        /// </summary>
        public const string ZTFUTA = "ZTFUTA";

        /// <summary>
        /// ZTTFEA.
        /// </summary>
        public const string ZTTFEA = "ZTTFEA";

        /// <summary>
        /// ZTFETA.
        /// </summary>
        public const string ZTFETA = "ZTFETA";

        /// <summary>
        /// ZTTPROV.
        /// </summary>
        public const string ZTTPROV = "ZTTPROV";

        /// <summary>
        /// ZTDTXJ.
        /// </summary>
        public const string ZTDTXJ = "ZTDTXJ";

        /// <summary>
        /// ZTCRCD.
        /// </summary>
        public const string ZTCRCD = "ZTCRCD";

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
        /// ZTUPMT.
        /// </summary>
        public const string ZTUPMT = "ZTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F4011ZTX";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZTEKCO", "ZTEKCO", JdeDataType.String, 10, true, true),
        new JdeField("ZTEDOC", "ZTEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("ZTEDCT", "ZTEDCT", JdeDataType.String, 4, true, true),
        new JdeField("ZTEDLN", "ZTEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("ZTTUPRC", "ZTTUPRC", JdeDataType.Numeric),
        new JdeField("ZTUTA", "ZTUTA", JdeDataType.Numeric),
        new JdeField("ZTTAEXP", "ZTTAEXP", JdeDataType.Numeric),
        new JdeField("ZTETA", "ZTETA", JdeDataType.Numeric),
        new JdeField("ZTTFUP", "ZTTFUP", JdeDataType.Numeric),
        new JdeField("ZTFUTA", "ZTFUTA", JdeDataType.Numeric),
        new JdeField("ZTTFEA", "ZTTFEA", JdeDataType.Numeric),
        new JdeField("ZTFETA", "ZTFETA", JdeDataType.Numeric),
        new JdeField("ZTTPROV", "ZTTPROV", JdeDataType.String, 2),
        new JdeField("ZTDTXJ", "ZTDTXJ", JdeDataType.Numeric),
        new JdeField("ZTCRCD", "ZTCRCD", JdeDataType.String, 6),
        new JdeField("ZTUSER", "ZTUSER", JdeDataType.String, 20),
        new JdeField("ZTPID", "ZTPID", JdeDataType.String, 20),
        new JdeField("ZTJOBN", "ZTJOBN", JdeDataType.String, 20),
        new JdeField("ZTUPMJ", "ZTUPMJ", JdeDataType.Numeric),
        new JdeField("ZTUPMT", "ZTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4011ZTX_0", "Primary Key on ZTEDOC, ZTEDCT, ZTEKCO, ZTEDLN", new[] { "ZTEDOC", "ZTEDCT", "ZTEKCO", "ZTEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
