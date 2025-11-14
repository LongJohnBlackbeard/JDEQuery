using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74UUI52 - .
/// </summary>
public class F74UUI52 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SMU74ICR.
        /// </summary>
        public const string SMU74ICR = "SMU74ICR";

        /// <summary>
        /// SMU74LAN8.
        /// </summary>
        public const string SMU74LAN8 = "SMU74LAN8";

        /// <summary>
        /// SMU74UTR.
        /// </summary>
        public const string SMU74UTR = "SMU74UTR";

        /// <summary>
        /// SMU74NATI.
        /// </summary>
        public const string SMU74NATI = "SMU74NATI";

        /// <summary>
        /// SMADD1.
        /// </summary>
        public const string SMADD1 = "SMADD1";

        /// <summary>
        /// SMADD2.
        /// </summary>
        public const string SMADD2 = "SMADD2";

        /// <summary>
        /// SMADD3.
        /// </summary>
        public const string SMADD3 = "SMADD3";

        /// <summary>
        /// SMADD4.
        /// </summary>
        public const string SMADD4 = "SMADD4";

        /// <summary>
        /// SMCTR.
        /// </summary>
        public const string SMCTR = "SMCTR";

        /// <summary>
        /// SMU74SCSU.
        /// </summary>
        public const string SMU74SCSU = "SMU74SCSU";

        /// <summary>
        /// SMU74SC1F.
        /// </summary>
        public const string SMU74SC1F = "SMU74SC1F";

        /// <summary>
        /// SMU74SC2F.
        /// </summary>
        public const string SMU74SC2F = "SMU74SC2F";

        /// <summary>
        /// SMU74SCMF.
        /// </summary>
        public const string SMU74SCMF = "SMU74SCMF";

        /// <summary>
        /// SMUKCRN.
        /// </summary>
        public const string SMUKCRN = "SMUKCRN";

        /// <summary>
        /// SMUKNTIN.
        /// </summary>
        public const string SMUKNTIN = "SMUKNTIN";

        /// <summary>
        /// SMU74SCVN.
        /// </summary>
        public const string SMU74SCVN = "SMU74SCVN";

        /// <summary>
        /// SMU74TOPM.
        /// </summary>
        public const string SMU74TOPM = "SMU74TOPM";

        /// <summary>
        /// SMU74TOCM.
        /// </summary>
        public const string SMU74TOCM = "SMU74TOCM";

        /// <summary>
        /// SMU74TOAD.
        /// </summary>
        public const string SMU74TOAD = "SMU74TOAD";

        /// <summary>
        /// SMUSER.
        /// </summary>
        public const string SMUSER = "SMUSER";

        /// <summary>
        /// SMPID.
        /// </summary>
        public const string SMPID = "SMPID";

        /// <summary>
        /// SMUPMJ.
        /// </summary>
        public const string SMUPMJ = "SMUPMJ";

        /// <summary>
        /// SMUPMT.
        /// </summary>
        public const string SMUPMT = "SMUPMT";

        /// <summary>
        /// SMJOBN.
        /// </summary>
        public const string SMJOBN = "SMJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74UUI52";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SMU74ICR", "SMU74ICR", JdeDataType.String, 28, true, true),
        new JdeField("SMU74LAN8", "SMU74LAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SMU74UTR", "SMU74UTR", JdeDataType.Numeric),
        new JdeField("SMU74NATI", "SMU74NATI", JdeDataType.String, 2),
        new JdeField("SMADD1", "SMADD1", JdeDataType.String, 80),
        new JdeField("SMADD2", "SMADD2", JdeDataType.String, 80),
        new JdeField("SMADD3", "SMADD3", JdeDataType.String, 80),
        new JdeField("SMADD4", "SMADD4", JdeDataType.String, 80),
        new JdeField("SMCTR", "SMCTR", JdeDataType.String, 6),
        new JdeField("SMU74SCSU", "SMU74SCSU", JdeDataType.String, 70),
        new JdeField("SMU74SC1F", "SMU74SC1F", JdeDataType.String, 70),
        new JdeField("SMU74SC2F", "SMU74SC2F", JdeDataType.String, 70),
        new JdeField("SMU74SCMF", "SMU74SCMF", JdeDataType.String, 2),
        new JdeField("SMUKCRN", "SMUKCRN", JdeDataType.String, 16),
        new JdeField("SMUKNTIN", "SMUKNTIN", JdeDataType.String, 18),
        new JdeField("SMU74SCVN", "SMU74SCVN", JdeDataType.String, 26),
        new JdeField("SMU74TOPM", "SMU74TOPM", JdeDataType.Numeric),
        new JdeField("SMU74TOCM", "SMU74TOCM", JdeDataType.Numeric),
        new JdeField("SMU74TOAD", "SMU74TOAD", JdeDataType.Numeric),
        new JdeField("SMUSER", "SMUSER", JdeDataType.String, 20),
        new JdeField("SMPID", "SMPID", JdeDataType.String, 20),
        new JdeField("SMUPMJ", "SMUPMJ", JdeDataType.Numeric),
        new JdeField("SMUPMT", "SMUPMT", JdeDataType.Numeric),
        new JdeField("SMJOBN", "SMJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74UUI52_0", "Primary Key on SMU74ICR, SMU74LAN8", new[] { "SMU74ICR", "SMU74LAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
