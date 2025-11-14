using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085536 - .
/// </summary>
public class F085536 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DHEVET.
        /// </summary>
        public const string DHEVET = "DHEVET";

        /// <summary>
        /// DHAN8.
        /// </summary>
        public const string DHAN8 = "DHAN8";

        /// <summary>
        /// DHPAN8.
        /// </summary>
        public const string DHPAN8 = "DHPAN8";

        /// <summary>
        /// DHMLNM.
        /// </summary>
        public const string DHMLNM = "DHMLNM";

        /// <summary>
        /// DHDBEN.
        /// </summary>
        public const string DHDBEN = "DHDBEN";

        /// <summary>
        /// DHRELA.
        /// </summary>
        public const string DHRELA = "DHRELA";

        /// <summary>
        /// DHPLAN.
        /// </summary>
        public const string DHPLAN = "DHPLAN";

        /// <summary>
        /// DHAOPT.
        /// </summary>
        public const string DHAOPT = "DHAOPT";

        /// <summary>
        /// DHEFT.
        /// </summary>
        public const string DHEFT = "DHEFT";

        /// <summary>
        /// DHEFTE.
        /// </summary>
        public const string DHEFTE = "DHEFTE";

        /// <summary>
        /// DHEECD.
        /// </summary>
        public const string DHEECD = "DHEECD";

        /// <summary>
        /// DHEDTE.
        /// </summary>
        public const string DHEDTE = "DHEDTE";

        /// <summary>
        /// DHPERC.
        /// </summary>
        public const string DHPERC = "DHPERC";

        /// <summary>
        /// DHSECPERC.
        /// </summary>
        public const string DHSECPERC = "DHSECPERC";

        /// <summary>
        /// DHNEWPERC.
        /// </summary>
        public const string DHNEWPERC = "DHNEWPERC";

        /// <summary>
        /// DHNSECPERC.
        /// </summary>
        public const string DHNSECPERC = "DHNSECPERC";

        /// <summary>
        /// DHPCP#.
        /// </summary>
        public const string DHPCP_ = "DHPCP#";

        /// <summary>
        /// DHPCPVST.
        /// </summary>
        public const string DHPCPVST = "DHPCPVST";

        /// <summary>
        /// DHACFL.
        /// </summary>
        public const string DHACFL = "DHACFL";

        /// <summary>
        /// DHUSER.
        /// </summary>
        public const string DHUSER = "DHUSER";

        /// <summary>
        /// DHPID.
        /// </summary>
        public const string DHPID = "DHPID";

        /// <summary>
        /// DHJOBN.
        /// </summary>
        public const string DHJOBN = "DHJOBN";

        /// <summary>
        /// DHUPMJ.
        /// </summary>
        public const string DHUPMJ = "DHUPMJ";

        /// <summary>
        /// DHUPMT.
        /// </summary>
        public const string DHUPMT = "DHUPMT";

        /// <summary>
        /// DHESIGN.
        /// </summary>
        public const string DHESIGN = "DHESIGN";

        /// <summary>
        /// DHMUMJ.
        /// </summary>
        public const string DHMUMJ = "DHMUMJ";

        /// <summary>
        /// DHMUMT.
        /// </summary>
        public const string DHMUMT = "DHMUMT";

        /// <summary>
        /// DHUPID.
        /// </summary>
        public const string DHUPID = "DHUPID";
    }

    /// <inheritdoc />
    public override string TableName => "F085536";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DHEVET", "DHEVET", JdeDataType.Numeric, null, true, true),
        new JdeField("DHAN8", "DHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DHPAN8", "DHPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("DHMLNM", "DHMLNM", JdeDataType.String, 80),
        new JdeField("DHDBEN", "DHDBEN", JdeDataType.String, 2, true, true),
        new JdeField("DHRELA", "DHRELA", JdeDataType.String, 2),
        new JdeField("DHPLAN", "DHPLAN", JdeDataType.String, 16, true, true),
        new JdeField("DHAOPT", "DHAOPT", JdeDataType.String, 6, true, true),
        new JdeField("DHEFT", "DHEFT", JdeDataType.Numeric),
        new JdeField("DHEFTE", "DHEFTE", JdeDataType.Numeric),
        new JdeField("DHEECD", "DHEECD", JdeDataType.String, 6),
        new JdeField("DHEDTE", "DHEDTE", JdeDataType.Numeric),
        new JdeField("DHPERC", "DHPERC", JdeDataType.Numeric),
        new JdeField("DHSECPERC", "DHSECPERC", JdeDataType.Numeric),
        new JdeField("DHNEWPERC", "DHNEWPERC", JdeDataType.Numeric),
        new JdeField("DHNSECPERC", "DHNSECPERC", JdeDataType.Numeric),
        new JdeField("DHPCP#", "DHPCP#", JdeDataType.String, 40),
        new JdeField("DHPCPVST", "DHPCPVST", JdeDataType.String, 2),
        new JdeField("DHACFL", "DHACFL", JdeDataType.String, 2),
        new JdeField("DHUSER", "DHUSER", JdeDataType.String, 20),
        new JdeField("DHPID", "DHPID", JdeDataType.String, 20),
        new JdeField("DHJOBN", "DHJOBN", JdeDataType.String, 20),
        new JdeField("DHUPMJ", "DHUPMJ", JdeDataType.Numeric),
        new JdeField("DHUPMT", "DHUPMT", JdeDataType.Numeric),
        new JdeField("DHESIGN", "DHESIGN", JdeDataType.String, 32, true, true),
        new JdeField("DHMUMJ", "DHMUMJ", JdeDataType.Numeric),
        new JdeField("DHMUMT", "DHMUMT", JdeDataType.Numeric),
        new JdeField("DHUPID", "DHUPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085536_0", "Primary Key on DHEVET, DHAN8, DHPAN8, DHDBEN, DHPLAN, DHAOPT, DHESIGN", new[] { "DHEVET", "DHAN8", "DHPAN8", "DHDBEN", "DHPLAN", "DHAOPT", "DHESIGN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F085536_2", "Index on DHEVET, DHAN8, DHDBEN, DHPLAN, DHAOPT, DHESIGN, SYS_NC00029$, SYS_NC00030$, DHPAN8", new[] { "DHEVET", "DHAN8", "DHDBEN", "DHPLAN", "DHAOPT", "DHESIGN", "SYS_NC00029$", "SYS_NC00030$", "DHPAN8" })
    };
}
