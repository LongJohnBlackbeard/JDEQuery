using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I837T - .
/// </summary>
public class F75I837T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GTKCO.
        /// </summary>
        public const string GTKCO = "GTKCO";

        /// <summary>
        /// GTDOC.
        /// </summary>
        public const string GTDOC = "GTDOC";

        /// <summary>
        /// GTDCT.
        /// </summary>
        public const string GTDCT = "GTDCT";

        /// <summary>
        /// GTSFX.
        /// </summary>
        public const string GTSFX = "GTSFX";

        /// <summary>
        /// GTI75CATTY.
        /// </summary>
        public const string GTI75CATTY = "GTI75CATTY";

        /// <summary>
        /// GTI75CATCO.
        /// </summary>
        public const string GTI75CATCO = "GTI75CATCO";

        /// <summary>
        /// GTI75CATVL.
        /// </summary>
        public const string GTI75CATVL = "GTI75CATVL";

        /// <summary>
        /// GTI75TXRL.
        /// </summary>
        public const string GTI75TXRL = "GTI75TXRL";

        /// <summary>
        /// GTUSER.
        /// </summary>
        public const string GTUSER = "GTUSER";

        /// <summary>
        /// GTPID.
        /// </summary>
        public const string GTPID = "GTPID";

        /// <summary>
        /// GTJOBN.
        /// </summary>
        public const string GTJOBN = "GTJOBN";

        /// <summary>
        /// GTUPMJ.
        /// </summary>
        public const string GTUPMJ = "GTUPMJ";

        /// <summary>
        /// GTUPMT.
        /// </summary>
        public const string GTUPMT = "GTUPMT";

        /// <summary>
        /// GTYFUTDT1.
        /// </summary>
        public const string GTYFUTDT1 = "GTYFUTDT1";

        /// <summary>
        /// GTFUT6.
        /// </summary>
        public const string GTFUT6 = "GTFUT6";

        /// <summary>
        /// GTYT04.
        /// </summary>
        public const string GTYT04 = "GTYT04";

        /// <summary>
        /// GTYFLAG.
        /// </summary>
        public const string GTYFLAG = "GTYFLAG";

        /// <summary>
        /// GTYNUM1.
        /// </summary>
        public const string GTYNUM1 = "GTYNUM1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I837T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GTKCO", "GTKCO", JdeDataType.String, 10, true, true),
        new JdeField("GTDOC", "GTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("GTDCT", "GTDCT", JdeDataType.String, 4, true, true),
        new JdeField("GTSFX", "GTSFX", JdeDataType.String, 6, true, true),
        new JdeField("GTI75CATTY", "GTI75CATTY", JdeDataType.String, 6),
        new JdeField("GTI75CATCO", "GTI75CATCO", JdeDataType.Numeric),
        new JdeField("GTI75CATVL", "GTI75CATVL", JdeDataType.String, 40),
        new JdeField("GTI75TXRL", "GTI75TXRL", JdeDataType.String, 12),
        new JdeField("GTUSER", "GTUSER", JdeDataType.String, 20),
        new JdeField("GTPID", "GTPID", JdeDataType.String, 20),
        new JdeField("GTJOBN", "GTJOBN", JdeDataType.String, 20),
        new JdeField("GTUPMJ", "GTUPMJ", JdeDataType.Numeric),
        new JdeField("GTUPMT", "GTUPMT", JdeDataType.Numeric),
        new JdeField("GTYFUTDT1", "GTYFUTDT1", JdeDataType.Numeric),
        new JdeField("GTFUT6", "GTFUT6", JdeDataType.String, 60),
        new JdeField("GTYT04", "GTYT04", JdeDataType.String, 2),
        new JdeField("GTYFLAG", "GTYFLAG", JdeDataType.String, 2),
        new JdeField("GTYNUM1", "GTYNUM1", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I837T_0", "Primary Key on GTKCO, GTDOC, GTDCT, GTSFX", new[] { "GTKCO", "GTDOC", "GTDCT", "GTSFX" }, isUnique: true, isPrimaryKey: true)
    };
}
