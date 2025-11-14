using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F740018 - .
/// </summary>
public class F740018 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AIKCOO.
        /// </summary>
        public const string AIKCOO = "AIKCOO";

        /// <summary>
        /// AIDCTO.
        /// </summary>
        public const string AIDCTO = "AIDCTO";

        /// <summary>
        /// AIDOCO.
        /// </summary>
        public const string AIDOCO = "AIDOCO";

        /// <summary>
        /// AISFXO.
        /// </summary>
        public const string AISFXO = "AISFXO";

        /// <summary>
        /// AILNID.
        /// </summary>
        public const string AILNID = "AILNID";

        /// <summary>
        /// AINLIN.
        /// </summary>
        public const string AINLIN = "AINLIN";

        /// <summary>
        /// AIC74STC.
        /// </summary>
        public const string AIC74STC = "AIC74STC";

        /// <summary>
        /// AIC74GAM.
        /// </summary>
        public const string AIC74GAM = "AIC74GAM";

        /// <summary>
        /// AIUSER.
        /// </summary>
        public const string AIUSER = "AIUSER";

        /// <summary>
        /// AIPID.
        /// </summary>
        public const string AIPID = "AIPID";

        /// <summary>
        /// AIJOBN.
        /// </summary>
        public const string AIJOBN = "AIJOBN";

        /// <summary>
        /// AIUPMT.
        /// </summary>
        public const string AIUPMT = "AIUPMT";

        /// <summary>
        /// AIUPMJ.
        /// </summary>
        public const string AIUPMJ = "AIUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F740018";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AIKCOO", "AIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("AIDCTO", "AIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("AIDOCO", "AIDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("AISFXO", "AISFXO", JdeDataType.String, 6, true, true),
        new JdeField("AILNID", "AILNID", JdeDataType.Numeric, null, true, true),
        new JdeField("AINLIN", "AINLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("AIC74STC", "AIC74STC", JdeDataType.String, 6),
        new JdeField("AIC74GAM", "AIC74GAM", JdeDataType.String, 6),
        new JdeField("AIUSER", "AIUSER", JdeDataType.String, 20),
        new JdeField("AIPID", "AIPID", JdeDataType.String, 20),
        new JdeField("AIJOBN", "AIJOBN", JdeDataType.String, 20),
        new JdeField("AIUPMT", "AIUPMT", JdeDataType.Numeric),
        new JdeField("AIUPMJ", "AIUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F740018_0", "Primary Key on AIKCOO, AIDCTO, AIDOCO, AISFXO, AILNID, AINLIN", new[] { "AIKCOO", "AIDCTO", "AIDOCO", "AISFXO", "AILNID", "AINLIN" }, isUnique: true, isPrimaryKey: true)
    };
}
