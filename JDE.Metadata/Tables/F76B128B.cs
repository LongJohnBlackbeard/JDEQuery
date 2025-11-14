using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B128B - .
/// </summary>
public class F76B128B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TCFCO.
        /// </summary>
        public const string TCFCO = "TCFCO";

        /// <summary>
        /// TCGIODT.
        /// </summary>
        public const string TCGIODT = "TCGIODT";

        /// <summary>
        /// TCGISIC.
        /// </summary>
        public const string TCGISIC = "TCGISIC";

        /// <summary>
        /// TCBRAESE.
        /// </summary>
        public const string TCBRAESE = "TCBRAESE";

        /// <summary>
        /// TCGIASTIA.
        /// </summary>
        public const string TCGIASTIA = "TCGIASTIA";

        /// <summary>
        /// TCGIOT.
        /// </summary>
        public const string TCGIOT = "TCGIOT";

        /// <summary>
        /// TCGIURC.
        /// </summary>
        public const string TCGIURC = "TCGIURC";

        /// <summary>
        /// TCGIURD.
        /// </summary>
        public const string TCGIURD = "TCGIURD";

        /// <summary>
        /// TCGIURA.
        /// </summary>
        public const string TCGIURA = "TCGIURA";

        /// <summary>
        /// TCGIURN.
        /// </summary>
        public const string TCGIURN = "TCGIURN";

        /// <summary>
        /// TCGIURR.
        /// </summary>
        public const string TCGIURR = "TCGIURR";

        /// <summary>
        /// TCUSER.
        /// </summary>
        public const string TCUSER = "TCUSER";

        /// <summary>
        /// TCPID.
        /// </summary>
        public const string TCPID = "TCPID";

        /// <summary>
        /// TCJOBN.
        /// </summary>
        public const string TCJOBN = "TCJOBN";

        /// <summary>
        /// TCUPMJ.
        /// </summary>
        public const string TCUPMJ = "TCUPMJ";

        /// <summary>
        /// TCUPMT.
        /// </summary>
        public const string TCUPMT = "TCUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B128B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TCFCO", "TCFCO", JdeDataType.String, 10, true, true),
        new JdeField("TCGIODT", "TCGIODT", JdeDataType.Numeric, null, true, true),
        new JdeField("TCGISIC", "TCGISIC", JdeDataType.String, 10, true, true),
        new JdeField("TCBRAESE", "TCBRAESE", JdeDataType.String, 40, true, true),
        new JdeField("TCGIASTIA", "TCGIASTIA", JdeDataType.Numeric),
        new JdeField("TCGIOT", "TCGIOT", JdeDataType.String, 2, true, true),
        new JdeField("TCGIURC", "TCGIURC", JdeDataType.String, 4),
        new JdeField("TCGIURD", "TCGIURD", JdeDataType.Numeric),
        new JdeField("TCGIURA", "TCGIURA", JdeDataType.Numeric),
        new JdeField("TCGIURN", "TCGIURN", JdeDataType.Numeric),
        new JdeField("TCGIURR", "TCGIURR", JdeDataType.String, 30),
        new JdeField("TCUSER", "TCUSER", JdeDataType.String, 20),
        new JdeField("TCPID", "TCPID", JdeDataType.String, 20),
        new JdeField("TCJOBN", "TCJOBN", JdeDataType.String, 20),
        new JdeField("TCUPMJ", "TCUPMJ", JdeDataType.Numeric),
        new JdeField("TCUPMT", "TCUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B128B_0", "Primary Key on TCFCO, TCGIODT, TCGISIC, TCBRAESE, TCGIOT", new[] { "TCFCO", "TCGIODT", "TCGISIC", "TCBRAESE", "TCGIOT" }, isUnique: true, isPrimaryKey: true)
    };
}
