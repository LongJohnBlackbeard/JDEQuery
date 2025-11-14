using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F471411 - .
/// </summary>
public class F471411 : JdeTable
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
        /// SZEDLN.
        /// </summary>
        public const string SZEDLN = "SZEDLN";

        /// <summary>
        /// SZPNID.
        /// </summary>
        public const string SZPNID = "SZPNID";

        /// <summary>
        /// SZEDSP.
        /// </summary>
        public const string SZEDSP = "SZEDSP";

        /// <summary>
        /// SZACKT.
        /// </summary>
        public const string SZACKT = "SZACKT";

        /// <summary>
        /// SZDTAI.
        /// </summary>
        public const string SZDTAI = "SZDTAI";

        /// <summary>
        /// SZDTI1.
        /// </summary>
        public const string SZDTI1 = "SZDTI1";

        /// <summary>
        /// SZDS80.
        /// </summary>
        public const string SZDS80 = "SZDS80";

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
    public override string TableName => "F471411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SZEKCO", "SZEKCO", JdeDataType.String, 10, true, true),
        new JdeField("SZEDOC", "SZEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("SZEDCT", "SZEDCT", JdeDataType.String, 4, true, true),
        new JdeField("SZEDLN", "SZEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("SZPNID", "SZPNID", JdeDataType.String, 30),
        new JdeField("SZEDSP", "SZEDSP", JdeDataType.String, 2),
        new JdeField("SZACKT", "SZACKT", JdeDataType.String, 4),
        new JdeField("SZDTAI", "SZDTAI", JdeDataType.String, 20),
        new JdeField("SZDTI1", "SZDTI1", JdeDataType.String, 20),
        new JdeField("SZDS80", "SZDS80", JdeDataType.String, 160),
        new JdeField("SZUSER", "SZUSER", JdeDataType.String, 20),
        new JdeField("SZPID", "SZPID", JdeDataType.String, 20),
        new JdeField("SZJOBN", "SZJOBN", JdeDataType.String, 20),
        new JdeField("SZUPMJ", "SZUPMJ", JdeDataType.Numeric),
        new JdeField("SZTDAY", "SZTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F471411_0", "Primary Key on SZEDOC, SZEDCT, SZEKCO, SZEDLN", new[] { "SZEDOC", "SZEDCT", "SZEKCO", "SZEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
