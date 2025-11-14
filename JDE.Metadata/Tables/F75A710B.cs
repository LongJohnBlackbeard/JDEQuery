using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A710B - .
/// </summary>
public class F75A710B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SXTAXX.
        /// </summary>
        public const string SXTAXX = "SXTAXX";

        /// <summary>
        /// SXGRPNO.
        /// </summary>
        public const string SXGRPNO = "SXGRPNO";

        /// <summary>
        /// SXASSPD.
        /// </summary>
        public const string SXASSPD = "SXASSPD";

        /// <summary>
        /// SXASSQ.
        /// </summary>
        public const string SXASSQ = "SXASSQ";

        /// <summary>
        /// SXAN8.
        /// </summary>
        public const string SXAN8 = "SXAN8";

        /// <summary>
        /// SXSPAFAUT1.
        /// </summary>
        public const string SXSPAFAUT1 = "SXSPAFAUT1";

        /// <summary>
        /// SXCKDT.
        /// </summary>
        public const string SXCKDT = "SXCKDT";

        /// <summary>
        /// SXHMCO.
        /// </summary>
        public const string SXHMCO = "SXHMCO";

        /// <summary>
        /// SXPAYD.
        /// </summary>
        public const string SXPAYD = "SXPAYD";

        /// <summary>
        /// SXPR83VAL.
        /// </summary>
        public const string SXPR83VAL = "SXPR83VAL";

        /// <summary>
        /// SXWASSAMT.
        /// </summary>
        public const string SXWASSAMT = "SXWASSAMT";

        /// <summary>
        /// SXWETPTAX.
        /// </summary>
        public const string SXWETPTAX = "SXWETPTAX";

        /// <summary>
        /// SXUPMJ.
        /// </summary>
        public const string SXUPMJ = "SXUPMJ";

        /// <summary>
        /// SXUPMT.
        /// </summary>
        public const string SXUPMT = "SXUPMT";

        /// <summary>
        /// SXPID.
        /// </summary>
        public const string SXPID = "SXPID";

        /// <summary>
        /// SXUSER.
        /// </summary>
        public const string SXUSER = "SXUSER";

        /// <summary>
        /// SXJOBN.
        /// </summary>
        public const string SXJOBN = "SXJOBN";

        /// <summary>
        /// SXSPACAUW1.
        /// </summary>
        public const string SXSPACAUW1 = "SXSPACAUW1";

        /// <summary>
        /// SXSPACAUW2.
        /// </summary>
        public const string SXSPACAUW2 = "SXSPACAUW2";

        /// <summary>
        /// SXSPACAUW3.
        /// </summary>
        public const string SXSPACAUW3 = "SXSPACAUW3";

        /// <summary>
        /// SXSPACAUW4.
        /// </summary>
        public const string SXSPACAUW4 = "SXSPACAUW4";

        /// <summary>
        /// SXSPANAUW1.
        /// </summary>
        public const string SXSPANAUW1 = "SXSPANAUW1";

        /// <summary>
        /// SXSPANAUW2.
        /// </summary>
        public const string SXSPANAUW2 = "SXSPANAUW2";

        /// <summary>
        /// SXSPANAUW3.
        /// </summary>
        public const string SXSPANAUW3 = "SXSPANAUW3";

        /// <summary>
        /// SXSPANAUW4.
        /// </summary>
        public const string SXSPANAUW4 = "SXSPANAUW4";

        /// <summary>
        /// SXSPADAUW1.
        /// </summary>
        public const string SXSPADAUW1 = "SXSPADAUW1";

        /// <summary>
        /// SXSPADAUW3.
        /// </summary>
        public const string SXSPADAUW3 = "SXSPADAUW3";

        /// <summary>
        /// SXSPASAUW1.
        /// </summary>
        public const string SXSPASAUW1 = "SXSPASAUW1";

        /// <summary>
        /// SXSPASAUW2.
        /// </summary>
        public const string SXSPASAUW2 = "SXSPASAUW2";

        /// <summary>
        /// SXSPASAUW3.
        /// </summary>
        public const string SXSPASAUW3 = "SXSPASAUW3";

        /// <summary>
        /// SXSPASAUW4.
        /// </summary>
        public const string SXSPASAUW4 = "SXSPASAUW4";

        /// <summary>
        /// SXCNOD.
        /// </summary>
        public const string SXCNOD = "SXCNOD";

        /// <summary>
        /// SXISYC.
        /// </summary>
        public const string SXISYC = "SXISYC";
    }

    /// <inheritdoc />
    public override string TableName => "F75A710B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SXTAXX", "SXTAXX", JdeDataType.String, 40, true, true),
        new JdeField("SXGRPNO", "SXGRPNO", JdeDataType.String, 22, true, true),
        new JdeField("SXASSPD", "SXASSPD", JdeDataType.Numeric, null, true, true),
        new JdeField("SXASSQ", "SXASSQ", JdeDataType.Numeric, null, true, true),
        new JdeField("SXAN8", "SXAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SXSPAFAUT1", "SXSPAFAUT1", JdeDataType.String, 2, true, true),
        new JdeField("SXCKDT", "SXCKDT", JdeDataType.Numeric, null, true, true),
        new JdeField("SXHMCO", "SXHMCO", JdeDataType.String, 10),
        new JdeField("SXPAYD", "SXPAYD", JdeDataType.String, 20),
        new JdeField("SXPR83VAL", "SXPR83VAL", JdeDataType.Numeric),
        new JdeField("SXWASSAMT", "SXWASSAMT", JdeDataType.Numeric),
        new JdeField("SXWETPTAX", "SXWETPTAX", JdeDataType.Numeric),
        new JdeField("SXUPMJ", "SXUPMJ", JdeDataType.Numeric),
        new JdeField("SXUPMT", "SXUPMT", JdeDataType.Numeric),
        new JdeField("SXPID", "SXPID", JdeDataType.String, 20),
        new JdeField("SXUSER", "SXUSER", JdeDataType.String, 20),
        new JdeField("SXJOBN", "SXJOBN", JdeDataType.String, 20),
        new JdeField("SXSPACAUW1", "SXSPACAUW1", JdeDataType.String, 2),
        new JdeField("SXSPACAUW2", "SXSPACAUW2", JdeDataType.String, 2),
        new JdeField("SXSPACAUW3", "SXSPACAUW3", JdeDataType.String, 2),
        new JdeField("SXSPACAUW4", "SXSPACAUW4", JdeDataType.String, 2),
        new JdeField("SXSPANAUW1", "SXSPANAUW1", JdeDataType.Numeric),
        new JdeField("SXSPANAUW2", "SXSPANAUW2", JdeDataType.Numeric),
        new JdeField("SXSPANAUW3", "SXSPANAUW3", JdeDataType.Numeric),
        new JdeField("SXSPANAUW4", "SXSPANAUW4", JdeDataType.Numeric),
        new JdeField("SXSPADAUW1", "SXSPADAUW1", JdeDataType.Numeric),
        new JdeField("SXSPADAUW3", "SXSPADAUW3", JdeDataType.Numeric),
        new JdeField("SXSPASAUW1", "SXSPASAUW1", JdeDataType.String, 60),
        new JdeField("SXSPASAUW2", "SXSPASAUW2", JdeDataType.String, 60),
        new JdeField("SXSPASAUW3", "SXSPASAUW3", JdeDataType.String, 60),
        new JdeField("SXSPASAUW4", "SXSPASAUW4", JdeDataType.String, 60),
        new JdeField("SXCNOD", "SXCNOD", JdeDataType.String, 4, true, true),
        new JdeField("SXISYC", "SXISYC", JdeDataType.String, 6, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A710B_0", "Primary Key on SXTAXX, SXGRPNO, SXASSPD, SXASSQ, SXAN8, SXISYC, SXSPAFAUT1, SXCKDT, SXCNOD", new[] { "SXTAXX", "SXGRPNO", "SXASSPD", "SXASSQ", "SXAN8", "SXISYC", "SXSPAFAUT1", "SXCKDT", "SXCNOD" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A710B_3", "Index on SXTAXX, SXGRPNO, SYS_NC00034$, SYS_NC00035$, SXAN8", new[] { "SXTAXX", "SXGRPNO", "SYS_NC00034$", "SYS_NC00035$", "SXAN8" }),
        new JdeIndex("F75A710B_4", "Index on SXTAXX, SXGRPNO, SYS_NC00034$, SYS_NC00035$", new[] { "SXTAXX", "SXGRPNO", "SYS_NC00034$", "SYS_NC00035$" })
    };
}
