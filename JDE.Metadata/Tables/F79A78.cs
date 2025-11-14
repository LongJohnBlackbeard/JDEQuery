using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F79A78 - .
/// </summary>
public class F79A78 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OT79AGTID.
        /// </summary>
        public const string OT79AGTID = "OT79AGTID";

        /// <summary>
        /// OT79AGOID.
        /// </summary>
        public const string OT79AGOID = "OT79AGOID";

        /// <summary>
        /// OT79ATG.
        /// </summary>
        public const string OT79ATG = "OT79ATG";

        /// <summary>
        /// OT79ASYN.
        /// </summary>
        public const string OT79ASYN = "OT79ASYN";

        /// <summary>
        /// OT79AGPES.
        /// </summary>
        public const string OT79AGPES = "OT79AGPES";

        /// <summary>
        /// OT79ATV.
        /// </summary>
        public const string OT79ATV = "OT79ATV";

        /// <summary>
        /// OT79AGUM.
        /// </summary>
        public const string OT79AGUM = "OT79AGUM";

        /// <summary>
        /// OTBEFD.
        /// </summary>
        public const string OTBEFD = "OTBEFD";

        /// <summary>
        /// OTEEFD.
        /// </summary>
        public const string OTEEFD = "OTEEFD";

        /// <summary>
        /// OTPID.
        /// </summary>
        public const string OTPID = "OTPID";

        /// <summary>
        /// OTUSER.
        /// </summary>
        public const string OTUSER = "OTUSER";

        /// <summary>
        /// OTJOBN.
        /// </summary>
        public const string OTJOBN = "OTJOBN";

        /// <summary>
        /// OTUPMJ.
        /// </summary>
        public const string OTUPMJ = "OTUPMJ";

        /// <summary>
        /// OTUPMT.
        /// </summary>
        public const string OTUPMT = "OTUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F79A78";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OT79AGTID", "OT79AGTID", JdeDataType.Numeric, null, true, true),
        new JdeField("OT79AGOID", "OT79AGOID", JdeDataType.Numeric),
        new JdeField("OT79ATG", "OT79ATG", JdeDataType.String, 60),
        new JdeField("OT79ASYN", "OT79ASYN", JdeDataType.String, 2),
        new JdeField("OT79AGPES", "OT79AGPES", JdeDataType.String, 50),
        new JdeField("OT79ATV", "OT79ATV", JdeDataType.Numeric),
        new JdeField("OT79AGUM", "OT79AGUM", JdeDataType.String, 30),
        new JdeField("OTBEFD", "OTBEFD", JdeDataType.Numeric),
        new JdeField("OTEEFD", "OTEEFD", JdeDataType.Numeric),
        new JdeField("OTPID", "OTPID", JdeDataType.String, 20),
        new JdeField("OTUSER", "OTUSER", JdeDataType.String, 20),
        new JdeField("OTJOBN", "OTJOBN", JdeDataType.String, 20),
        new JdeField("OTUPMJ", "OTUPMJ", JdeDataType.Numeric),
        new JdeField("OTUPMT", "OTUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F79A78_0", "Primary Key on OT79AGTID", new[] { "OT79AGTID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F79A78_3", "Index on OT79AGPES", new[] { "OT79AGPES" }),
        new JdeIndex("F79A78_4", "Index on OT79AGOID, OT79ATG, OT79ASYN, OT79AGPES", new[] { "OT79AGOID", "OT79ATG", "OT79ASYN", "OT79AGPES" }),
        new JdeIndex("F79A78_5", "Unique Index on OT79AGOID, OT79ATG, OT79ASYN, OT79AGPES, OTBEFD", new[] { "OT79AGOID", "OT79ATG", "OT79ASYN", "OT79AGPES", "OTBEFD" }, isUnique: true),
        new JdeIndex("F79A78_6", "Index on OT79AGOID", new[] { "OT79AGOID" })
    };
}
