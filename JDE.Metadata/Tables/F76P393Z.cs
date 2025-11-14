using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76P393Z - .
/// </summary>
public class F76P393Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CZAAJU.
        /// </summary>
        public const string CZAAJU = "CZAAJU";

        /// <summary>
        /// CZFY.
        /// </summary>
        public const string CZFY = "CZFY";

        /// <summary>
        /// CZPN.
        /// </summary>
        public const string CZPN = "CZPN";

        /// <summary>
        /// CZCO.
        /// </summary>
        public const string CZCO = "CZCO";

        /// <summary>
        /// CZITM.
        /// </summary>
        public const string CZITM = "CZITM";

        /// <summary>
        /// CZMCU.
        /// </summary>
        public const string CZMCU = "CZMCU";

        /// <summary>
        /// CZLOCN.
        /// </summary>
        public const string CZLOCN = "CZLOCN";

        /// <summary>
        /// CZLOTN.
        /// </summary>
        public const string CZLOTN = "CZLOTN";

        /// <summary>
        /// CZUPRC.
        /// </summary>
        public const string CZUPRC = "CZUPRC";

        /// <summary>
        /// CZUSER.
        /// </summary>
        public const string CZUSER = "CZUSER";

        /// <summary>
        /// CZPID.
        /// </summary>
        public const string CZPID = "CZPID";

        /// <summary>
        /// CZUPMJ.
        /// </summary>
        public const string CZUPMJ = "CZUPMJ";

        /// <summary>
        /// CZUPMT.
        /// </summary>
        public const string CZUPMT = "CZUPMT";

        /// <summary>
        /// CZJOBN.
        /// </summary>
        public const string CZJOBN = "CZJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F76P393Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CZAAJU", "CZAAJU", JdeDataType.String, 20, true, true),
        new JdeField("CZFY", "CZFY", JdeDataType.Numeric, null, true, true),
        new JdeField("CZPN", "CZPN", JdeDataType.Numeric, null, true, true),
        new JdeField("CZCO", "CZCO", JdeDataType.String, 10, true, true),
        new JdeField("CZITM", "CZITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CZMCU", "CZMCU", JdeDataType.String, 24, true, true),
        new JdeField("CZLOCN", "CZLOCN", JdeDataType.String, 40, true, true),
        new JdeField("CZLOTN", "CZLOTN", JdeDataType.String, 60, true, true),
        new JdeField("CZUPRC", "CZUPRC", JdeDataType.Numeric),
        new JdeField("CZUSER", "CZUSER", JdeDataType.String, 20),
        new JdeField("CZPID", "CZPID", JdeDataType.String, 20),
        new JdeField("CZUPMJ", "CZUPMJ", JdeDataType.Numeric),
        new JdeField("CZUPMT", "CZUPMT", JdeDataType.Numeric),
        new JdeField("CZJOBN", "CZJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76P393Z_0", "Primary Key on CZAAJU, CZFY, CZPN, CZCO, CZITM, CZMCU, CZLOCN, CZLOTN", new[] { "CZAAJU", "CZFY", "CZPN", "CZCO", "CZITM", "CZMCU", "CZLOCN", "CZLOTN" }, isUnique: true, isPrimaryKey: true)
    };
}
