using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F744102T - .
/// </summary>
public class F744102T : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCDCD.
        /// </summary>
        public const string CCCDCD = "CCCDCD";

        /// <summary>
        /// CCITM.
        /// </summary>
        public const string CCITM = "CCITM";

        /// <summary>
        /// CCSHCM.
        /// </summary>
        public const string CCSHCM = "CCSHCM";

        /// <summary>
        /// CCC74STC.
        /// </summary>
        public const string CCC74STC = "CCC74STC";

        /// <summary>
        /// CCC74GAM.
        /// </summary>
        public const string CCC74GAM = "CCC74GAM";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F744102T";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCDCD", "CCCDCD", JdeDataType.String, 30, true, true),
        new JdeField("CCITM", "CCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CCSHCM", "CCSHCM", JdeDataType.String, 6),
        new JdeField("CCC74STC", "CCC74STC", JdeDataType.String, 6),
        new JdeField("CCC74GAM", "CCC74GAM", JdeDataType.String, 6),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F744102T_0", "Primary Key on CCCDCD, CCITM", new[] { "CCCDCD", "CCITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F744102T_2", "Index on CCSHCM, CCITM", new[] { "CCSHCM", "CCITM" }),
        new JdeIndex("F744102T_3", "Index on CCCDCD, CCSHCM", new[] { "CCCDCD", "CCSHCM" })
    };
}
