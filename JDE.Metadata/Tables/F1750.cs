using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1750 - .
/// </summary>
public class F1750 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRITYPE.
        /// </summary>
        public const string CRITYPE = "CRITYPE";

        /// <summary>
        /// CRDSS5.
        /// </summary>
        public const string CRDSS5 = "CRDSS5";

        /// <summary>
        /// CRYN01.
        /// </summary>
        public const string CRYN01 = "CRYN01";

        /// <summary>
        /// CRYN02.
        /// </summary>
        public const string CRYN02 = "CRYN02";

        /// <summary>
        /// CRYN03.
        /// </summary>
        public const string CRYN03 = "CRYN03";

        /// <summary>
        /// CRYN04.
        /// </summary>
        public const string CRYN04 = "CRYN04";

        /// <summary>
        /// CRYN05.
        /// </summary>
        public const string CRYN05 = "CRYN05";

        /// <summary>
        /// CRYN06.
        /// </summary>
        public const string CRYN06 = "CRYN06";

        /// <summary>
        /// CRYN07.
        /// </summary>
        public const string CRYN07 = "CRYN07";

        /// <summary>
        /// CRYN08.
        /// </summary>
        public const string CRYN08 = "CRYN08";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRYN09.
        /// </summary>
        public const string CRYN09 = "CRYN09";

        /// <summary>
        /// CRYN10.
        /// </summary>
        public const string CRYN10 = "CRYN10";

        /// <summary>
        /// CRYN11.
        /// </summary>
        public const string CRYN11 = "CRYN11";

        /// <summary>
        /// CRYN12.
        /// </summary>
        public const string CRYN12 = "CRYN12";

        /// <summary>
        /// CRYN13.
        /// </summary>
        public const string CRYN13 = "CRYN13";

        /// <summary>
        /// CRYN14.
        /// </summary>
        public const string CRYN14 = "CRYN14";

        /// <summary>
        /// CRYN15.
        /// </summary>
        public const string CRYN15 = "CRYN15";
    }

    /// <inheritdoc />
    public override string TableName => "F1750";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRITYPE", "CRITYPE", JdeDataType.String, 2, true, true),
        new JdeField("CRDSS5", "CRDSS5", JdeDataType.Numeric, null, true, true),
        new JdeField("CRYN01", "CRYN01", JdeDataType.String, 2),
        new JdeField("CRYN02", "CRYN02", JdeDataType.String, 2),
        new JdeField("CRYN03", "CRYN03", JdeDataType.String, 2),
        new JdeField("CRYN04", "CRYN04", JdeDataType.String, 2),
        new JdeField("CRYN05", "CRYN05", JdeDataType.String, 2),
        new JdeField("CRYN06", "CRYN06", JdeDataType.String, 2),
        new JdeField("CRYN07", "CRYN07", JdeDataType.String, 2),
        new JdeField("CRYN08", "CRYN08", JdeDataType.String, 2),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRYN09", "CRYN09", JdeDataType.String, 2),
        new JdeField("CRYN10", "CRYN10", JdeDataType.String, 2),
        new JdeField("CRYN11", "CRYN11", JdeDataType.String, 2),
        new JdeField("CRYN12", "CRYN12", JdeDataType.String, 2),
        new JdeField("CRYN13", "CRYN13", JdeDataType.String, 2),
        new JdeField("CRYN14", "CRYN14", JdeDataType.String, 2),
        new JdeField("CRYN15", "CRYN15", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1750_0", "Primary Key on CRITYPE, CRDSS5", new[] { "CRITYPE", "CRDSS5" }, isUnique: true, isPrimaryKey: true)
    };
}
