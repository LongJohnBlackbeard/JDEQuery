using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75Z0003 - .
/// </summary>
public class F75Z0003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// Z3AN8.
        /// </summary>
        public const string Z3AN8 = "Z3AN8";

        /// <summary>
        /// Z3STDLVBAL.
        /// </summary>
        public const string Z3STDLVBAL = "Z3STDLVBAL";

        /// <summary>
        /// Z3STDLVCOM.
        /// </summary>
        public const string Z3STDLVCOM = "Z3STDLVCOM";

        /// <summary>
        /// Z3ACCRTIA.
        /// </summary>
        public const string Z3ACCRTIA = "Z3ACCRTIA";

        /// <summary>
        /// Z3ACCRCOM.
        /// </summary>
        public const string Z3ACCRCOM = "Z3ACCRCOM";

        /// <summary>
        /// Z3YTDGRSE.
        /// </summary>
        public const string Z3YTDGRSE = "Z3YTDGRSE";

        /// <summary>
        /// Z3YTDHRS.
        /// </summary>
        public const string Z3YTDHRS = "Z3YTDHRS";

        /// <summary>
        /// Z3SHFTCNT.
        /// </summary>
        public const string Z3SHFTCNT = "Z3SHFTCNT";

        /// <summary>
        /// Z3UPMJ.
        /// </summary>
        public const string Z3UPMJ = "Z3UPMJ";

        /// <summary>
        /// Z3UPMT.
        /// </summary>
        public const string Z3UPMT = "Z3UPMT";

        /// <summary>
        /// Z3PID.
        /// </summary>
        public const string Z3PID = "Z3PID";

        /// <summary>
        /// Z3USER.
        /// </summary>
        public const string Z3USER = "Z3USER";

        /// <summary>
        /// Z3JOBN.
        /// </summary>
        public const string Z3JOBN = "Z3JOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F75Z0003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("Z3AN8", "Z3AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("Z3STDLVBAL", "Z3STDLVBAL", JdeDataType.Numeric),
        new JdeField("Z3STDLVCOM", "Z3STDLVCOM", JdeDataType.Numeric),
        new JdeField("Z3ACCRTIA", "Z3ACCRTIA", JdeDataType.Numeric),
        new JdeField("Z3ACCRCOM", "Z3ACCRCOM", JdeDataType.Numeric),
        new JdeField("Z3YTDGRSE", "Z3YTDGRSE", JdeDataType.Numeric),
        new JdeField("Z3YTDHRS", "Z3YTDHRS", JdeDataType.Numeric),
        new JdeField("Z3SHFTCNT", "Z3SHFTCNT", JdeDataType.Numeric),
        new JdeField("Z3UPMJ", "Z3UPMJ", JdeDataType.Numeric),
        new JdeField("Z3UPMT", "Z3UPMT", JdeDataType.Numeric),
        new JdeField("Z3PID", "Z3PID", JdeDataType.String, 20),
        new JdeField("Z3USER", "Z3USER", JdeDataType.String, 20),
        new JdeField("Z3JOBN", "Z3JOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75Z0003_0", "Primary Key on Z3AN8", new[] { "Z3AN8" }, isUnique: true, isPrimaryKey: true)
    };
}
