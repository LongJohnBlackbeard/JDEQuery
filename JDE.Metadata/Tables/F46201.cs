using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46201 - .
/// </summary>
public class F46201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCAN8.
        /// </summary>
        public const string CCAN8 = "CCAN8";

        /// <summary>
        /// CCSHAN.
        /// </summary>
        public const string CCSHAN = "CCSHAN";

        /// <summary>
        /// CCITM.
        /// </summary>
        public const string CCITM = "CCITM";

        /// <summary>
        /// CCVR01.
        /// </summary>
        public const string CCVR01 = "CCVR01";

        /// <summary>
        /// CCDVAN.
        /// </summary>
        public const string CCDVAN = "CCDVAN";

        /// <summary>
        /// CCCHGREF.
        /// </summary>
        public const string CCCHGREF = "CCCHGREF";

        /// <summary>
        /// CCCCHB.
        /// </summary>
        public const string CCCCHB = "CCCCHB";

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
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCTDAY.
        /// </summary>
        public const string CCTDAY = "CCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F46201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCAN8", "CCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CCSHAN", "CCSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("CCITM", "CCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("CCVR01", "CCVR01", JdeDataType.String, 50, true, true),
        new JdeField("CCDVAN", "CCDVAN", JdeDataType.Numeric, null, true, true),
        new JdeField("CCCHGREF", "CCCHGREF", JdeDataType.String, 40),
        new JdeField("CCCCHB", "CCCCHB", JdeDataType.String, 2),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCTDAY", "CCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46201_0", "Primary Key on CCAN8, CCSHAN, CCITM, CCVR01, CCDVAN", new[] { "CCAN8", "CCSHAN", "CCITM", "CCVR01", "CCDVAN" }, isUnique: true, isPrimaryKey: true)
    };
}
