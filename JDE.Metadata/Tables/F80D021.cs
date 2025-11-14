using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D021 - .
/// </summary>
public class F80D021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// FRFAAI.
        /// </summary>
        public const string FRFAAI = "FRFAAI";

        /// <summary>
        /// FRFRNG1.
        /// </summary>
        public const string FRFRNG1 = "FRFRNG1";

        /// <summary>
        /// FRFRNG2.
        /// </summary>
        public const string FRFRNG2 = "FRFRNG2";

        /// <summary>
        /// FRFRNG3.
        /// </summary>
        public const string FRFRNG3 = "FRFRNG3";

        /// <summary>
        /// FRFRNG4.
        /// </summary>
        public const string FRFRNG4 = "FRFRNG4";

        /// <summary>
        /// FRFRNG5.
        /// </summary>
        public const string FRFRNG5 = "FRFRNG5";

        /// <summary>
        /// FRFRNG6.
        /// </summary>
        public const string FRFRNG6 = "FRFRNG6";

        /// <summary>
        /// FRFRNG7.
        /// </summary>
        public const string FRFRNG7 = "FRFRNG7";

        /// <summary>
        /// FRFRNG8.
        /// </summary>
        public const string FRFRNG8 = "FRFRNG8";

        /// <summary>
        /// FRUSER.
        /// </summary>
        public const string FRUSER = "FRUSER";

        /// <summary>
        /// FRPID.
        /// </summary>
        public const string FRPID = "FRPID";

        /// <summary>
        /// FRMKEY.
        /// </summary>
        public const string FRMKEY = "FRMKEY";

        /// <summary>
        /// FRUTIME.
        /// </summary>
        public const string FRUTIME = "FRUTIME";

        /// <summary>
        /// FRURCD.
        /// </summary>
        public const string FRURCD = "FRURCD";

        /// <summary>
        /// FRURDT.
        /// </summary>
        public const string FRURDT = "FRURDT";

        /// <summary>
        /// FRURAT.
        /// </summary>
        public const string FRURAT = "FRURAT";

        /// <summary>
        /// FRURAB.
        /// </summary>
        public const string FRURAB = "FRURAB";

        /// <summary>
        /// FRURRF.
        /// </summary>
        public const string FRURRF = "FRURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("FRFAAI", "FRFAAI", JdeDataType.String, 8, true, true),
        new JdeField("FRFRNG1", "FRFRNG1", JdeDataType.String, 4),
        new JdeField("FRFRNG2", "FRFRNG2", JdeDataType.String, 4),
        new JdeField("FRFRNG3", "FRFRNG3", JdeDataType.String, 4),
        new JdeField("FRFRNG4", "FRFRNG4", JdeDataType.String, 4),
        new JdeField("FRFRNG5", "FRFRNG5", JdeDataType.String, 4),
        new JdeField("FRFRNG6", "FRFRNG6", JdeDataType.String, 4),
        new JdeField("FRFRNG7", "FRFRNG7", JdeDataType.String, 4),
        new JdeField("FRFRNG8", "FRFRNG8", JdeDataType.String, 4),
        new JdeField("FRUSER", "FRUSER", JdeDataType.String, 20),
        new JdeField("FRPID", "FRPID", JdeDataType.String, 20),
        new JdeField("FRMKEY", "FRMKEY", JdeDataType.String, 30),
        new JdeField("FRUTIME", "FRUTIME", JdeDataType.Date),
        new JdeField("FRURCD", "FRURCD", JdeDataType.String, 4),
        new JdeField("FRURDT", "FRURDT", JdeDataType.Numeric),
        new JdeField("FRURAT", "FRURAT", JdeDataType.Numeric),
        new JdeField("FRURAB", "FRURAB", JdeDataType.Numeric),
        new JdeField("FRURRF", "FRURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D021_0", "Primary Key on FRFAAI", new[] { "FRFAAI" }, isUnique: true, isPrimaryKey: true)
    };
}
