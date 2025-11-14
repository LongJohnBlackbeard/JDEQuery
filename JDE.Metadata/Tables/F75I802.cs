using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I802 - .
/// </summary>
public class F75I802 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TRI75TXRL.
        /// </summary>
        public const string TRI75TXRL = "TRI75TXRL";

        /// <summary>
        /// TRI75RECU.
        /// </summary>
        public const string TRI75RECU = "TRI75RECU";

        /// <summary>
        /// TRI75DFFG.
        /// </summary>
        public const string TRI75DFFG = "TRI75DFFG";

        /// <summary>
        /// TRI75DFPER.
        /// </summary>
        public const string TRI75DFPER = "TRI75DFPER";

        /// <summary>
        /// TRI75FRC.
        /// </summary>
        public const string TRI75FRC = "TRI75FRC";

        /// <summary>
        /// TRI75PSP.
        /// </summary>
        public const string TRI75PSP = "TRI75PSP";

        /// <summary>
        /// TRI75PSR.
        /// </summary>
        public const string TRI75PSR = "TRI75PSR";

        /// <summary>
        /// TREFDJ.
        /// </summary>
        public const string TREFDJ = "TREFDJ";

        /// <summary>
        /// TREFTJ.
        /// </summary>
        public const string TREFTJ = "TREFTJ";

        /// <summary>
        /// TRUSER.
        /// </summary>
        public const string TRUSER = "TRUSER";

        /// <summary>
        /// TRPID.
        /// </summary>
        public const string TRPID = "TRPID";

        /// <summary>
        /// TRUPMJ.
        /// </summary>
        public const string TRUPMJ = "TRUPMJ";

        /// <summary>
        /// TRUPMT.
        /// </summary>
        public const string TRUPMT = "TRUPMT";

        /// <summary>
        /// TRJOBN.
        /// </summary>
        public const string TRJOBN = "TRJOBN";

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
    }

    /// <inheritdoc />
    public override string TableName => "F75I802";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TRI75TXRL", "TRI75TXRL", JdeDataType.String, 12, true, true),
        new JdeField("TRI75RECU", "TRI75RECU", JdeDataType.String, 2),
        new JdeField("TRI75DFFG", "TRI75DFFG", JdeDataType.String, 2),
        new JdeField("TRI75DFPER", "TRI75DFPER", JdeDataType.Numeric),
        new JdeField("TRI75FRC", "TRI75FRC", JdeDataType.String, 2),
        new JdeField("TRI75PSP", "TRI75PSP", JdeDataType.Numeric),
        new JdeField("TRI75PSR", "TRI75PSR", JdeDataType.Numeric),
        new JdeField("TREFDJ", "TREFDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TREFTJ", "TREFTJ", JdeDataType.Numeric, null, true, true),
        new JdeField("TRUSER", "TRUSER", JdeDataType.String, 20),
        new JdeField("TRPID", "TRPID", JdeDataType.String, 20),
        new JdeField("TRUPMJ", "TRUPMJ", JdeDataType.Numeric),
        new JdeField("TRUPMT", "TRUPMT", JdeDataType.Numeric),
        new JdeField("TRJOBN", "TRJOBN", JdeDataType.String, 20),
        new JdeField("TRYFUTDT1", "TRYFUTDT1", JdeDataType.Numeric),
        new JdeField("TRFUT6", "TRFUT6", JdeDataType.String, 60),
        new JdeField("TRYT04", "TRYT04", JdeDataType.String, 2),
        new JdeField("TRYFLAG", "TRYFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I802_0", "Primary Key on TRI75TXRL, TREFTJ, TREFDJ", new[] { "TRI75TXRL", "TREFTJ", "TREFDJ" }, isUnique: true, isPrimaryKey: true)
    };
}
