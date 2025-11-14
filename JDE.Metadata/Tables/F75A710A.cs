using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A710A - .
/// </summary>
public class F75A710A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// STTAXX.
        /// </summary>
        public const string STTAXX = "STTAXX";

        /// <summary>
        /// STGRPNO.
        /// </summary>
        public const string STGRPNO = "STGRPNO";

        /// <summary>
        /// STASSPD.
        /// </summary>
        public const string STASSPD = "STASSPD";

        /// <summary>
        /// STASSQ.
        /// </summary>
        public const string STASSQ = "STASSQ";

        /// <summary>
        /// STAN8.
        /// </summary>
        public const string STAN8 = "STAN8";

        /// <summary>
        /// STASEOT.
        /// </summary>
        public const string STASEOT = "STASEOT";

        /// <summary>
        /// STASEOC.
        /// </summary>
        public const string STASEOC = "STASEOC";

        /// <summary>
        /// STHMCO.
        /// </summary>
        public const string STHMCO = "STHMCO";

        /// <summary>
        /// STPAYD.
        /// </summary>
        public const string STPAYD = "STPAYD";

        /// <summary>
        /// STASETA.
        /// </summary>
        public const string STASETA = "STASETA";

        /// <summary>
        /// STUPMJ.
        /// </summary>
        public const string STUPMJ = "STUPMJ";

        /// <summary>
        /// STUPMT.
        /// </summary>
        public const string STUPMT = "STUPMT";

        /// <summary>
        /// STPID.
        /// </summary>
        public const string STPID = "STPID";

        /// <summary>
        /// STUSER.
        /// </summary>
        public const string STUSER = "STUSER";

        /// <summary>
        /// STJOBN.
        /// </summary>
        public const string STJOBN = "STJOBN";

        /// <summary>
        /// STISYC.
        /// </summary>
        public const string STISYC = "STISYC";

        /// <summary>
        /// STCNOD.
        /// </summary>
        public const string STCNOD = "STCNOD";

        /// <summary>
        /// STSPACAUB1.
        /// </summary>
        public const string STSPACAUB1 = "STSPACAUB1";

        /// <summary>
        /// STSPACAUB2.
        /// </summary>
        public const string STSPACAUB2 = "STSPACAUB2";

        /// <summary>
        /// STSPACAUB3.
        /// </summary>
        public const string STSPACAUB3 = "STSPACAUB3";

        /// <summary>
        /// STSPACAUB4.
        /// </summary>
        public const string STSPACAUB4 = "STSPACAUB4";

        /// <summary>
        /// STSPADAUB1.
        /// </summary>
        public const string STSPADAUB1 = "STSPADAUB1";

        /// <summary>
        /// STSPADAUB2.
        /// </summary>
        public const string STSPADAUB2 = "STSPADAUB2";

        /// <summary>
        /// STSPADAUB3.
        /// </summary>
        public const string STSPADAUB3 = "STSPADAUB3";

        /// <summary>
        /// STSPADAUB4.
        /// </summary>
        public const string STSPADAUB4 = "STSPADAUB4";

        /// <summary>
        /// STSPANAUB1.
        /// </summary>
        public const string STSPANAUB1 = "STSPANAUB1";

        /// <summary>
        /// STSPANAUB2.
        /// </summary>
        public const string STSPANAUB2 = "STSPANAUB2";

        /// <summary>
        /// STSPANAUB3.
        /// </summary>
        public const string STSPANAUB3 = "STSPANAUB3";

        /// <summary>
        /// STSPANAUB4.
        /// </summary>
        public const string STSPANAUB4 = "STSPANAUB4";

        /// <summary>
        /// STSPASAUB1.
        /// </summary>
        public const string STSPASAUB1 = "STSPASAUB1";

        /// <summary>
        /// STSPASAUB2.
        /// </summary>
        public const string STSPASAUB2 = "STSPASAUB2";

        /// <summary>
        /// STSPASAUB3.
        /// </summary>
        public const string STSPASAUB3 = "STSPASAUB3";

        /// <summary>
        /// STSPASAUB4.
        /// </summary>
        public const string STSPASAUB4 = "STSPASAUB4";
    }

    /// <inheritdoc />
    public override string TableName => "F75A710A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("STTAXX", "STTAXX", JdeDataType.String, 40, true, true),
        new JdeField("STGRPNO", "STGRPNO", JdeDataType.String, 22, true, true),
        new JdeField("STASSPD", "STASSPD", JdeDataType.Numeric, null, true, true),
        new JdeField("STASSQ", "STASSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("STAN8", "STAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("STASEOT", "STASEOT", JdeDataType.String, 20, true, true),
        new JdeField("STASEOC", "STASEOC", JdeDataType.String, 4, true, true),
        new JdeField("STHMCO", "STHMCO", JdeDataType.String, 10),
        new JdeField("STPAYD", "STPAYD", JdeDataType.String, 20),
        new JdeField("STASETA", "STASETA", JdeDataType.Numeric),
        new JdeField("STUPMJ", "STUPMJ", JdeDataType.Numeric),
        new JdeField("STUPMT", "STUPMT", JdeDataType.Numeric),
        new JdeField("STPID", "STPID", JdeDataType.String, 20),
        new JdeField("STUSER", "STUSER", JdeDataType.String, 20),
        new JdeField("STJOBN", "STJOBN", JdeDataType.String, 20),
        new JdeField("STISYC", "STISYC", JdeDataType.String, 6, true, true),
        new JdeField("STCNOD", "STCNOD", JdeDataType.String, 4, true, true),
        new JdeField("STSPACAUB1", "STSPACAUB1", JdeDataType.String, 2),
        new JdeField("STSPACAUB2", "STSPACAUB2", JdeDataType.String, 2),
        new JdeField("STSPACAUB3", "STSPACAUB3", JdeDataType.String, 2),
        new JdeField("STSPACAUB4", "STSPACAUB4", JdeDataType.String, 2),
        new JdeField("STSPADAUB1", "STSPADAUB1", JdeDataType.Numeric),
        new JdeField("STSPADAUB2", "STSPADAUB2", JdeDataType.Numeric),
        new JdeField("STSPADAUB3", "STSPADAUB3", JdeDataType.Numeric),
        new JdeField("STSPADAUB4", "STSPADAUB4", JdeDataType.Numeric),
        new JdeField("STSPANAUB1", "STSPANAUB1", JdeDataType.Numeric),
        new JdeField("STSPANAUB2", "STSPANAUB2", JdeDataType.Numeric),
        new JdeField("STSPANAUB3", "STSPANAUB3", JdeDataType.Numeric),
        new JdeField("STSPANAUB4", "STSPANAUB4", JdeDataType.Numeric),
        new JdeField("STSPASAUB1", "STSPASAUB1", JdeDataType.String, 60),
        new JdeField("STSPASAUB2", "STSPASAUB2", JdeDataType.String, 60),
        new JdeField("STSPASAUB3", "STSPASAUB3", JdeDataType.String, 60),
        new JdeField("STSPASAUB4", "STSPASAUB4", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A710A_0", "Primary Key on STTAXX, STGRPNO, STASSPD, STASSQ, STAN8, STISYC, STASEOT, STASEOC, STCNOD", new[] { "STTAXX", "STGRPNO", "STASSPD", "STASSQ", "STAN8", "STISYC", "STASEOT", "STASEOC", "STCNOD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A710A_4", "Index on STTAXX, STGRPNO, SYS_NC00034$, SYS_NC00035$, STAN8", new[] { "STTAXX", "STGRPNO", "SYS_NC00034$", "SYS_NC00035$", "STAN8" }),
        new JdeIndex("F75A710A_5", "Index on STTAXX, STGRPNO, SYS_NC00034$, SYS_NC00035$", new[] { "STTAXX", "STGRPNO", "SYS_NC00034$", "SYS_NC00035$" })
    };
}
