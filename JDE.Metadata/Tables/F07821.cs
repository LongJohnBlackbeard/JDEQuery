using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F07821 - .
/// </summary>
public class F07821 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JGDTEY.
        /// </summary>
        public const string JGDTEY = "JGDTEY";

        /// <summary>
        /// JGCO.
        /// </summary>
        public const string JGCO = "JGCO";

        /// <summary>
        /// JGTFYE.
        /// </summary>
        public const string JGTFYE = "JGTFYE";

        /// <summary>
        /// JGIDYE.
        /// </summary>
        public const string JGIDYE = "JGIDYE";

        /// <summary>
        /// JGTWYE.
        /// </summary>
        public const string JGTWYE = "JGTWYE";

        /// <summary>
        /// JGTAXX.
        /// </summary>
        public const string JGTAXX = "JGTAXX";

        /// <summary>
        /// JGDTCF.
        /// </summary>
        public const string JGDTCF = "JGDTCF";

        /// <summary>
        /// JGW2EE.
        /// </summary>
        public const string JGW2EE = "JGW2EE";

        /// <summary>
        /// JGW2N.
        /// </summary>
        public const string JGW2N = "JGW2N";

        /// <summary>
        /// JGW2P.
        /// </summary>
        public const string JGW2P = "JGW2P";

        /// <summary>
        /// JGW2P1.
        /// </summary>
        public const string JGW2P1 = "JGW2P1";

        /// <summary>
        /// JGUPMJ.
        /// </summary>
        public const string JGUPMJ = "JGUPMJ";

        /// <summary>
        /// JGUPMT.
        /// </summary>
        public const string JGUPMT = "JGUPMT";

        /// <summary>
        /// JGPID.
        /// </summary>
        public const string JGPID = "JGPID";

        /// <summary>
        /// JGJOBN.
        /// </summary>
        public const string JGJOBN = "JGJOBN";

        /// <summary>
        /// JGUSER.
        /// </summary>
        public const string JGUSER = "JGUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F07821";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JGDTEY", "JGDTEY", JdeDataType.Numeric, null, true, true),
        new JdeField("JGCO", "JGCO", JdeDataType.String, 10, true, true),
        new JdeField("JGTFYE", "JGTFYE", JdeDataType.String, 2, true, true),
        new JdeField("JGIDYE", "JGIDYE", JdeDataType.String, 20, true, true),
        new JdeField("JGTWYE", "JGTWYE", JdeDataType.String, 2, true, true),
        new JdeField("JGTAXX", "JGTAXX", JdeDataType.String, 40, true, true),
        new JdeField("JGDTCF", "JGDTCF", JdeDataType.Numeric, null, true, true),
        new JdeField("JGW2EE", "JGW2EE", JdeDataType.Numeric),
        new JdeField("JGW2N", "JGW2N", JdeDataType.Numeric),
        new JdeField("JGW2P", "JGW2P", JdeDataType.Numeric),
        new JdeField("JGW2P1", "JGW2P1", JdeDataType.Numeric),
        new JdeField("JGUPMJ", "JGUPMJ", JdeDataType.Numeric),
        new JdeField("JGUPMT", "JGUPMT", JdeDataType.Numeric),
        new JdeField("JGPID", "JGPID", JdeDataType.String, 20),
        new JdeField("JGJOBN", "JGJOBN", JdeDataType.String, 20),
        new JdeField("JGUSER", "JGUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F07821_0", "Primary Key on JGIDYE, JGDTEY, JGTAXX, JGCO, JGTFYE, JGTWYE, JGDTCF", new[] { "JGIDYE", "JGDTEY", "JGTAXX", "JGCO", "JGTFYE", "JGTWYE", "JGDTCF" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F07821_3", "Index on JGIDYE, JGDTEY, JGTFYE, JGCO", new[] { "JGIDYE", "JGDTEY", "JGTFYE", "JGCO" }),
        new JdeIndex("F07821_4", "Index on JGIDYE, JGDTEY, JGCO, JGTFYE, JGTWYE", new[] { "JGIDYE", "JGDTEY", "JGCO", "JGTFYE", "JGTWYE" })
    };
}
