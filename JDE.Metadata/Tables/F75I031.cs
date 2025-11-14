using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I031 - .
/// </summary>
public class F75I031 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIKCO.
        /// </summary>
        public const string PIKCO = "PIKCO";

        /// <summary>
        /// PIDCT.
        /// </summary>
        public const string PIDCT = "PIDCT";

        /// <summary>
        /// PIDOC.
        /// </summary>
        public const string PIDOC = "PIDOC";

        /// <summary>
        /// PIAN8.
        /// </summary>
        public const string PIAN8 = "PIAN8";

        /// <summary>
        /// PIANTY.
        /// </summary>
        public const string PIANTY = "PIANTY";

        /// <summary>
        /// PII75RETY.
        /// </summary>
        public const string PII75RETY = "PII75RETY";

        /// <summary>
        /// PII75CERC.
        /// </summary>
        public const string PII75CERC = "PII75CERC";

        /// <summary>
        /// PID03.
        /// </summary>
        public const string PID03 = "PID03";

        /// <summary>
        /// PII75ECCN.
        /// </summary>
        public const string PII75ECCN = "PII75ECCN";

        /// <summary>
        /// PII75ORAC.
        /// </summary>
        public const string PII75ORAC = "PII75ORAC";

        /// <summary>
        /// PII75RNGE.
        /// </summary>
        public const string PII75RNGE = "PII75RNGE";

        /// <summary>
        /// PII75DVSN.
        /// </summary>
        public const string PII75DVSN = "PII75DVSN";

        /// <summary>
        /// PII75ZONE.
        /// </summary>
        public const string PII75ZONE = "PII75ZONE";

        /// <summary>
        /// PII75REGN.
        /// </summary>
        public const string PII75REGN = "PII75REGN";

        /// <summary>
        /// PII75CIRC.
        /// </summary>
        public const string PII75CIRC = "PII75CIRC";

        /// <summary>
        /// PII75COTR.
        /// </summary>
        public const string PII75COTR = "PII75COTR";

        /// <summary>
        /// PII75CST.
        /// </summary>
        public const string PII75CST = "PII75CST";

        /// <summary>
        /// PID02.
        /// </summary>
        public const string PID02 = "PID02";

        /// <summary>
        /// PII75LST.
        /// </summary>
        public const string PII75LST = "PII75LST";

        /// <summary>
        /// PID01.
        /// </summary>
        public const string PID01 = "PID01";

        /// <summary>
        /// PII75SERT.
        /// </summary>
        public const string PII75SERT = "PII75SERT";

        /// <summary>
        /// PID04.
        /// </summary>
        public const string PID04 = "PID04";

        /// <summary>
        /// PII75WCT.
        /// </summary>
        public const string PII75WCT = "PII75WCT";

        /// <summary>
        /// PID05.
        /// </summary>
        public const string PID05 = "PID05";

        /// <summary>
        /// PII75TIN.
        /// </summary>
        public const string PII75TIN = "PII75TIN";

        /// <summary>
        /// PID06.
        /// </summary>
        public const string PID06 = "PID06";

        /// <summary>
        /// PIYTN1.
        /// </summary>
        public const string PIYTN1 = "PIYTN1";

        /// <summary>
        /// PIYPN1.
        /// </summary>
        public const string PIYPN1 = "PIYPN1";
    }

    /// <inheritdoc />
    public override string TableName => "F75I031";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PIAN8", "PIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PIANTY", "PIANTY", JdeDataType.String, 2, true, true),
        new JdeField("PII75RETY", "PII75RETY", JdeDataType.String, 6),
        new JdeField("PII75CERC", "PII75CERC", JdeDataType.String, 30),
        new JdeField("PID03", "PID03", JdeDataType.Numeric),
        new JdeField("PII75ECCN", "PII75ECCN", JdeDataType.String, 30),
        new JdeField("PII75ORAC", "PII75ORAC", JdeDataType.String, 80),
        new JdeField("PII75RNGE", "PII75RNGE", JdeDataType.String, 80),
        new JdeField("PII75DVSN", "PII75DVSN", JdeDataType.String, 80),
        new JdeField("PII75ZONE", "PII75ZONE", JdeDataType.String, 80),
        new JdeField("PII75REGN", "PII75REGN", JdeDataType.String, 80),
        new JdeField("PII75CIRC", "PII75CIRC", JdeDataType.String, 80),
        new JdeField("PII75COTR", "PII75COTR", JdeDataType.String, 80),
        new JdeField("PII75CST", "PII75CST", JdeDataType.String, 80),
        new JdeField("PID02", "PID02", JdeDataType.Numeric),
        new JdeField("PII75LST", "PII75LST", JdeDataType.String, 80),
        new JdeField("PID01", "PID01", JdeDataType.Numeric),
        new JdeField("PII75SERT", "PII75SERT", JdeDataType.String, 30),
        new JdeField("PID04", "PID04", JdeDataType.Numeric),
        new JdeField("PII75WCT", "PII75WCT", JdeDataType.String, 80),
        new JdeField("PID05", "PID05", JdeDataType.Numeric),
        new JdeField("PII75TIN", "PII75TIN", JdeDataType.String, 80),
        new JdeField("PID06", "PID06", JdeDataType.Numeric),
        new JdeField("PIYTN1", "PIYTN1", JdeDataType.String, 80),
        new JdeField("PIYPN1", "PIYPN1", JdeDataType.String, 80)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I031_0", "Primary Key on PIKCO, PIDCT, PIDOC, PIAN8, PIANTY", new[] { "PIKCO", "PIDCT", "PIDOC", "PIAN8", "PIANTY" }, isUnique: true, isPrimaryKey: true)
    };
}
