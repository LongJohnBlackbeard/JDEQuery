using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74S79 - .
/// </summary>
public class F74S79 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TQSYEA.
        /// </summary>
        public const string TQSYEA = "TQSYEA";

        /// <summary>
        /// TQS74IDY.
        /// </summary>
        public const string TQS74IDY = "TQS74IDY";

        /// <summary>
        /// TQSTID.
        /// </summary>
        public const string TQSTID = "TQSTID";

        /// <summary>
        /// TQSOTP.
        /// </summary>
        public const string TQSOTP = "TQSOTP";

        /// <summary>
        /// TQSCVT.
        /// </summary>
        public const string TQSCVT = "TQSCVT";

        /// <summary>
        /// TQSIOP.
        /// </summary>
        public const string TQSIOP = "TQSIOP";

        /// <summary>
        /// TQSLOP.
        /// </summary>
        public const string TQSLOP = "TQSLOP";

        /// <summary>
        /// TQSRTI.
        /// </summary>
        public const string TQSRTI = "TQSRTI";

        /// <summary>
        /// TQCO.
        /// </summary>
        public const string TQCO = "TQCO";

        /// <summary>
        /// TQBCRC.
        /// </summary>
        public const string TQBCRC = "TQBCRC";

        /// <summary>
        /// TQS74TAQ1.
        /// </summary>
        public const string TQS74TAQ1 = "TQS74TAQ1";

        /// <summary>
        /// TQS74TAQ2.
        /// </summary>
        public const string TQS74TAQ2 = "TQS74TAQ2";

        /// <summary>
        /// TQS74TAQ3.
        /// </summary>
        public const string TQS74TAQ3 = "TQS74TAQ3";

        /// <summary>
        /// TQS74TAQ4.
        /// </summary>
        public const string TQS74TAQ4 = "TQS74TAQ4";

        /// <summary>
        /// TQS74ARPQ1.
        /// </summary>
        public const string TQS74ARPQ1 = "TQS74ARPQ1";

        /// <summary>
        /// TQS74ARPQ2.
        /// </summary>
        public const string TQS74ARPQ2 = "TQS74ARPQ2";

        /// <summary>
        /// TQS74ARPQ3.
        /// </summary>
        public const string TQS74ARPQ3 = "TQS74ARPQ3";

        /// <summary>
        /// TQS74ARPQ4.
        /// </summary>
        public const string TQS74ARPQ4 = "TQS74ARPQ4";

        /// <summary>
        /// TQUSER.
        /// </summary>
        public const string TQUSER = "TQUSER";

        /// <summary>
        /// TQPID.
        /// </summary>
        public const string TQPID = "TQPID";

        /// <summary>
        /// TQJOBN.
        /// </summary>
        public const string TQJOBN = "TQJOBN";

        /// <summary>
        /// TQUPMJ.
        /// </summary>
        public const string TQUPMJ = "TQUPMJ";

        /// <summary>
        /// TQUPMT.
        /// </summary>
        public const string TQUPMT = "TQUPMT";

        /// <summary>
        /// TQS74COCN.
        /// </summary>
        public const string TQS74COCN = "TQS74COCN";

        /// <summary>
        /// TQS74SDVR.
        /// </summary>
        public const string TQS74SDVR = "TQS74SDVR";

        /// <summary>
        /// TQS74RVCT.
        /// </summary>
        public const string TQS74RVCT = "TQS74RVCT";

        /// <summary>
        /// TQS74GOTC.
        /// </summary>
        public const string TQS74GOTC = "TQS74GOTC";
    }

    /// <inheritdoc />
    public override string TableName => "F74S79";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TQSYEA", "TQSYEA", JdeDataType.Numeric, null, true, true),
        new JdeField("TQS74IDY", "TQS74IDY", JdeDataType.Numeric, null, true, true),
        new JdeField("TQSTID", "TQSTID", JdeDataType.String, 18, true, true),
        new JdeField("TQSOTP", "TQSOTP", JdeDataType.String, 2, true, true),
        new JdeField("TQSCVT", "TQSCVT", JdeDataType.String, 18, true, true),
        new JdeField("TQSIOP", "TQSIOP", JdeDataType.String, 2, true, true),
        new JdeField("TQSLOP", "TQSLOP", JdeDataType.String, 2, true, true),
        new JdeField("TQSRTI", "TQSRTI", JdeDataType.Numeric),
        new JdeField("TQCO", "TQCO", JdeDataType.String, 10),
        new JdeField("TQBCRC", "TQBCRC", JdeDataType.String, 6),
        new JdeField("TQS74TAQ1", "TQS74TAQ1", JdeDataType.Numeric),
        new JdeField("TQS74TAQ2", "TQS74TAQ2", JdeDataType.Numeric),
        new JdeField("TQS74TAQ3", "TQS74TAQ3", JdeDataType.Numeric),
        new JdeField("TQS74TAQ4", "TQS74TAQ4", JdeDataType.Numeric),
        new JdeField("TQS74ARPQ1", "TQS74ARPQ1", JdeDataType.Numeric),
        new JdeField("TQS74ARPQ2", "TQS74ARPQ2", JdeDataType.Numeric),
        new JdeField("TQS74ARPQ3", "TQS74ARPQ3", JdeDataType.Numeric),
        new JdeField("TQS74ARPQ4", "TQS74ARPQ4", JdeDataType.Numeric),
        new JdeField("TQUSER", "TQUSER", JdeDataType.String, 20),
        new JdeField("TQPID", "TQPID", JdeDataType.String, 20),
        new JdeField("TQJOBN", "TQJOBN", JdeDataType.String, 20),
        new JdeField("TQUPMJ", "TQUPMJ", JdeDataType.Numeric),
        new JdeField("TQUPMT", "TQUPMT", JdeDataType.Numeric),
        new JdeField("TQS74COCN", "TQS74COCN", JdeDataType.String, 34, true, true),
        new JdeField("TQS74SDVR", "TQS74SDVR", JdeDataType.String, 2, true, true),
        new JdeField("TQS74RVCT", "TQS74RVCT", JdeDataType.String, 2, true, true),
        new JdeField("TQS74GOTC", "TQS74GOTC", JdeDataType.String, 2, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74S79_0", "Primary Key on TQSTID, TQSYEA, TQS74IDY, TQSCVT, TQS74COCN, TQSOTP, TQSIOP, TQSLOP, TQS74SDVR, TQS74RVCT, TQS74GOTC", new[] { "TQSTID", "TQSYEA", "TQS74IDY", "TQSCVT", "TQS74COCN", "TQSOTP", "TQSIOP", "TQSLOP", "TQS74SDVR", "TQS74RVCT", "TQS74GOTC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74S79_2", "Index on TQSYEA, TQSRTI, TQSTID", new[] { "TQSYEA", "TQSRTI", "TQSTID" })
    };
}
