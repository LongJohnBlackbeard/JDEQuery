using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75A0301 - .
/// </summary>
public class F75A0301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SAAN8.
        /// </summary>
        public const string SAAN8 = "SAAN8";

        /// <summary>
        /// SAACC.
        /// </summary>
        public const string SAACC = "SAACC";

        /// <summary>
        /// SACO.
        /// </summary>
        public const string SACO = "SACO";

        /// <summary>
        /// SAHMCU.
        /// </summary>
        public const string SAHMCU = "SAHMCU";

        /// <summary>
        /// SACKCN.
        /// </summary>
        public const string SACKCN = "SACKCN";

        /// <summary>
        /// SAANN8.
        /// </summary>
        public const string SAANN8 = "SAANN8";

        /// <summary>
        /// SAPALP.
        /// </summary>
        public const string SAPALP = "SAPALP";

        /// <summary>
        /// SAPH1.
        /// </summary>
        public const string SAPH1 = "SAPH1";

        /// <summary>
        /// SAAPD.
        /// </summary>
        public const string SAAPD = "SAAPD";

        /// <summary>
        /// SACKDT.
        /// </summary>
        public const string SACKDT = "SACKDT";

        /// <summary>
        /// SAPPDT.
        /// </summary>
        public const string SAPPDT = "SAPPDT";

        /// <summary>
        /// SAUPMJ.
        /// </summary>
        public const string SAUPMJ = "SAUPMJ";

        /// <summary>
        /// SAUPMT.
        /// </summary>
        public const string SAUPMT = "SAUPMT";

        /// <summary>
        /// SAPID.
        /// </summary>
        public const string SAPID = "SAPID";

        /// <summary>
        /// SAJOBN.
        /// </summary>
        public const string SAJOBN = "SAJOBN";

        /// <summary>
        /// SAUSER.
        /// </summary>
        public const string SAUSER = "SAUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F75A0301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SAAN8", "SAAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SAACC", "SAACC", JdeDataType.String, 32, true, true),
        new JdeField("SACO", "SACO", JdeDataType.String, 10),
        new JdeField("SAHMCU", "SAHMCU", JdeDataType.String, 24),
        new JdeField("SACKCN", "SACKCN", JdeDataType.Numeric, null, true, true),
        new JdeField("SAANN8", "SAANN8", JdeDataType.Numeric),
        new JdeField("SAPALP", "SAPALP", JdeDataType.String, 100),
        new JdeField("SAPH1", "SAPH1", JdeDataType.String, 40),
        new JdeField("SAAPD", "SAAPD", JdeDataType.Numeric),
        new JdeField("SACKDT", "SACKDT", JdeDataType.Numeric, null, true, true),
        new JdeField("SAPPDT", "SAPPDT", JdeDataType.Numeric),
        new JdeField("SAUPMJ", "SAUPMJ", JdeDataType.Numeric),
        new JdeField("SAUPMT", "SAUPMT", JdeDataType.Numeric),
        new JdeField("SAPID", "SAPID", JdeDataType.String, 20),
        new JdeField("SAJOBN", "SAJOBN", JdeDataType.String, 20),
        new JdeField("SAUSER", "SAUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75A0301_0", "Primary Key on SAAN8, SAACC, SACKDT, SACKCN", new[] { "SAAN8", "SAACC", "SACKDT", "SACKCN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75A0301_2", "Index on SACO, SAHMCU, SAAN8, SACKCN, SAACC", new[] { "SACO", "SAHMCU", "SAAN8", "SACKCN", "SAACC" }),
        new JdeIndex("F75A0301_3", "Index on SACKCN, SAACC, SACKDT", new[] { "SACKCN", "SAACC", "SACKDT" }),
        new JdeIndex("F75A0301_4", "Index on SYS_NC00017$", new[] { "SYS_NC00017$" })
    };
}
