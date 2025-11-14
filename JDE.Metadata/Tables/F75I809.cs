using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I809 - .
/// </summary>
public class F75I809 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRI75CATTY.
        /// </summary>
        public const string TRI75CATTY = "TRI75CATTY";

        /// <summary>
        /// TRI75CATCO.
        /// </summary>
        public const string TRI75CATCO = "TRI75CATCO";

        /// <summary>
        /// TREFTJ.
        /// </summary>
        public const string TREFTJ = "TREFTJ";

        /// <summary>
        /// TRI75CGSTR.
        /// </summary>
        public const string TRI75CGSTR = "TRI75CGSTR";

        /// <summary>
        /// TRI75SGSTR.
        /// </summary>
        public const string TRI75SGSTR = "TRI75SGSTR";

        /// <summary>
        /// TRI75IGSTR.
        /// </summary>
        public const string TRI75IGSTR = "TRI75IGSTR";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRUPMT.
        /// </summary>
        public const string TRUPMT = "TRUPMT";

        /// <summary>
        /// TRYFUTDT1.
        /// </summary>
        public const string TRYFUTDT1 = "TRYFUTDT1";

        /// <summary>
        /// TRFUT6.
        /// </summary>
        public const string TRFUT6 = "TRFUT6";

        /// <summary>
        /// TRYT04.
        /// </summary>
        public const string TRYT04 = "TRYT04";

        /// <summary>
        /// TRYFLAG.
        /// </summary>
        public const string TRYFLAG = "TRYFLAG";

        /// <summary>
        /// TRI75CESSR.
        /// </summary>
        public const string TRI75CESSR = "TRI75CESSR";

        /// <summary>
        /// TRI75ATX1R.
        /// </summary>
        public const string TRI75ATX1R = "TRI75ATX1R";

        /// <summary>
        /// TRI75ATX2R.
        /// </summary>
        public const string TRI75ATX2R = "TRI75ATX2R";

        /// <summary>
        /// TRI75ATX3R.
        /// </summary>
        public const string TRI75ATX3R = "TRI75ATX3R";

        /// <summary>
        /// TRI75AT4R.
        /// </summary>
        public const string TRI75AT4R = "TRI75AT4R";
    }

    /// <inheritdoc />
    public override string TableName => "F75I809";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRI75CATTY", "TRI75CATTY", JdeDataType.String, 6, true, true),
        new JdeField("TRI75CATCO", "TRI75CATCO", JdeDataType.Numeric, null, true, true),
        new JdeField("TREFTJ", "TREFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TRI75CGSTR", "TRI75CGSTR", JdeDataType.Numeric),
        new JdeField("TRI75SGSTR", "TRI75SGSTR", JdeDataType.Numeric),
        new JdeField("TRI75IGSTR", "TRI75IGSTR", JdeDataType.Numeric),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRUPMT", "TRUPMT", JdeDataType.Numeric),
        new JdeField("TRYFUTDT1", "TRYFUTDT1", JdeDataType.Numeric),
        new JdeField("TRFUT6", "TRFUT6", JdeDataType.String, 60),
        new JdeField("TRYT04", "TRYT04", JdeDataType.String, 2),
        new JdeField("TRYFLAG", "TRYFLAG", JdeDataType.String, 2),
        new JdeField("TRI75CESSR", "TRI75CESSR", JdeDataType.Numeric),
        new JdeField("TRI75ATX1R", "TRI75ATX1R", JdeDataType.Numeric),
        new JdeField("TRI75ATX2R", "TRI75ATX2R", JdeDataType.Numeric),
        new JdeField("TRI75ATX3R", "TRI75ATX3R", JdeDataType.Numeric),
        new JdeField("TRI75AT4R", "TRI75AT4R", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I809_0", "Primary Key on TRI75CATCO, TREFTJ, TRI75CATTY", new[] { "TRI75CATCO", "TREFTJ", "TRI75CATTY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75I809_2", "Index on TRI75CATCO, SYS_NC00021$, TRI75CATTY", new[] { "TRI75CATCO", "SYS_NC00021$", "TRI75CATTY" })
    };
}
