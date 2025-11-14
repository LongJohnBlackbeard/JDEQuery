using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW63 - .
/// </summary>
public class FCW63 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFC9ITM.
        /// </summary>
        public const string WFC9ITM = "WFC9ITM";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFC9CAT1.
        /// </summary>
        public const string WFC9CAT1 = "WFC9CAT1";

        /// <summary>
        /// WFC9CAT2.
        /// </summary>
        public const string WFC9CAT2 = "WFC9CAT2";

        /// <summary>
        /// WFC9CAT3.
        /// </summary>
        public const string WFC9CAT3 = "WFC9CAT3";

        /// <summary>
        /// WFC9CAT4.
        /// </summary>
        public const string WFC9CAT4 = "WFC9CAT4";

        /// <summary>
        /// WFC9CAT5.
        /// </summary>
        public const string WFC9CAT5 = "WFC9CAT5";

        /// <summary>
        /// WFC9CAT6.
        /// </summary>
        public const string WFC9CAT6 = "WFC9CAT6";

        /// <summary>
        /// WFC9CAT7.
        /// </summary>
        public const string WFC9CAT7 = "WFC9CAT7";

        /// <summary>
        /// WFC9CAT8.
        /// </summary>
        public const string WFC9CAT8 = "WFC9CAT8";

        /// <summary>
        /// WFC9CAT9.
        /// </summary>
        public const string WFC9CAT9 = "WFC9CAT9";

        /// <summary>
        /// WFC9CAT0.
        /// </summary>
        public const string WFC9CAT0 = "WFC9CAT0";

        /// <summary>
        /// WFC9WASH.
        /// </summary>
        public const string WFC9WASH = "WFC9WASH";

        /// <summary>
        /// WFC9CHLO.
        /// </summary>
        public const string WFC9CHLO = "WFC9CHLO";

        /// <summary>
        /// WFC9IRON.
        /// </summary>
        public const string WFC9IRON = "WFC9IRON";

        /// <summary>
        /// WFC9DCLE.
        /// </summary>
        public const string WFC9DCLE = "WFC9DCLE";

        /// <summary>
        /// WFC9WRIN.
        /// </summary>
        public const string WFC9WRIN = "WFC9WRIN";

        /// <summary>
        /// WFC9SITM.
        /// </summary>
        public const string WFC9SITM = "WFC9SITM";

        /// <summary>
        /// WFC9MITM.
        /// </summary>
        public const string WFC9MITM = "WFC9MITM";

        /// <summary>
        /// WFC9TUSR.
        /// </summary>
        public const string WFC9TUSR = "WFC9TUSR";

        /// <summary>
        /// WFC9TITM.
        /// </summary>
        public const string WFC9TITM = "WFC9TITM";

        /// <summary>
        /// WFC9TMOD.
        /// </summary>
        public const string WFC9TMOD = "WFC9TMOD";
    }

    /// <inheritdoc />
    public override string TableName => "FCW63";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFC9ITM", "WFC9ITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFC9CAT1", "WFC9CAT1", JdeDataType.String, 20),
        new JdeField("WFC9CAT2", "WFC9CAT2", JdeDataType.String, 20),
        new JdeField("WFC9CAT3", "WFC9CAT3", JdeDataType.String, 20),
        new JdeField("WFC9CAT4", "WFC9CAT4", JdeDataType.String, 20),
        new JdeField("WFC9CAT5", "WFC9CAT5", JdeDataType.String, 20),
        new JdeField("WFC9CAT6", "WFC9CAT6", JdeDataType.String, 20),
        new JdeField("WFC9CAT7", "WFC9CAT7", JdeDataType.String, 20),
        new JdeField("WFC9CAT8", "WFC9CAT8", JdeDataType.String, 20),
        new JdeField("WFC9CAT9", "WFC9CAT9", JdeDataType.String, 20),
        new JdeField("WFC9CAT0", "WFC9CAT0", JdeDataType.String, 20),
        new JdeField("WFC9WASH", "WFC9WASH", JdeDataType.String, 2),
        new JdeField("WFC9CHLO", "WFC9CHLO", JdeDataType.String, 2),
        new JdeField("WFC9IRON", "WFC9IRON", JdeDataType.String, 2),
        new JdeField("WFC9DCLE", "WFC9DCLE", JdeDataType.String, 2),
        new JdeField("WFC9WRIN", "WFC9WRIN", JdeDataType.String, 2),
        new JdeField("WFC9SITM", "WFC9SITM", JdeDataType.Numeric),
        new JdeField("WFC9MITM", "WFC9MITM", JdeDataType.Numeric),
        new JdeField("WFC9TUSR", "WFC9TUSR", JdeDataType.String, 20),
        new JdeField("WFC9TITM", "WFC9TITM", JdeDataType.Numeric),
        new JdeField("WFC9TMOD", "WFC9TMOD", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW63_0", "Primary Key on WFC9ITM, WFEV01", new[] { "WFC9ITM", "WFEV01" }, isUnique: true, isPrimaryKey: true)
    };
}
