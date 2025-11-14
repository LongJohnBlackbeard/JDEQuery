using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F749105 - .
/// </summary>
public class F749105 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EDE74RENA.
        /// </summary>
        public const string EDE74RENA = "EDE74RENA";

        /// <summary>
        /// EDE74RSN.
        /// </summary>
        public const string EDE74RSN = "EDE74RSN";

        /// <summary>
        /// EDE74RRN.
        /// </summary>
        public const string EDE74RRN = "EDE74RRN";

        /// <summary>
        /// EDE74CNO.
        /// </summary>
        public const string EDE74CNO = "EDE74CNO";

        /// <summary>
        /// EDE74COTY.
        /// </summary>
        public const string EDE74COTY = "EDE74COTY";

        /// <summary>
        /// EDE74FORM.
        /// </summary>
        public const string EDE74FORM = "EDE74FORM";

        /// <summary>
        /// EDE74FACT.
        /// </summary>
        public const string EDE74FACT = "EDE74FACT";

        /// <summary>
        /// EDE74FUNC.
        /// </summary>
        public const string EDE74FUNC = "EDE74FUNC";

        /// <summary>
        /// EDFYOF.
        /// </summary>
        public const string EDFYOF = "EDFYOF";

        /// <summary>
        /// EDPNOF.
        /// </summary>
        public const string EDPNOF = "EDPNOF";

        /// <summary>
        /// EDLT.
        /// </summary>
        public const string EDLT = "EDLT";

        /// <summary>
        /// EDCRCD.
        /// </summary>
        public const string EDCRCD = "EDCRCD";

        /// <summary>
        /// EDUSER.
        /// </summary>
        public const string EDUSER = "EDUSER";

        /// <summary>
        /// EDJOBN.
        /// </summary>
        public const string EDJOBN = "EDJOBN";

        /// <summary>
        /// EDPID.
        /// </summary>
        public const string EDPID = "EDPID";

        /// <summary>
        /// EDUPMJ.
        /// </summary>
        public const string EDUPMJ = "EDUPMJ";

        /// <summary>
        /// EDUPMT.
        /// </summary>
        public const string EDUPMT = "EDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F749105";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EDE74RENA", "EDE74RENA", JdeDataType.String, 40, true, true),
        new JdeField("EDE74RSN", "EDE74RSN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDE74RRN", "EDE74RRN", JdeDataType.Numeric, null, true, true),
        new JdeField("EDE74CNO", "EDE74CNO", JdeDataType.String, 4, true, true),
        new JdeField("EDE74COTY", "EDE74COTY", JdeDataType.String, 2),
        new JdeField("EDE74FORM", "EDE74FORM", JdeDataType.String, 480),
        new JdeField("EDE74FACT", "EDE74FACT", JdeDataType.String, 2),
        new JdeField("EDE74FUNC", "EDE74FUNC", JdeDataType.String, 20),
        new JdeField("EDFYOF", "EDFYOF", JdeDataType.String, 6),
        new JdeField("EDPNOF", "EDPNOF", JdeDataType.String, 6),
        new JdeField("EDLT", "EDLT", JdeDataType.String, 4),
        new JdeField("EDCRCD", "EDCRCD", JdeDataType.String, 6),
        new JdeField("EDUSER", "EDUSER", JdeDataType.String, 20),
        new JdeField("EDJOBN", "EDJOBN", JdeDataType.String, 20),
        new JdeField("EDPID", "EDPID", JdeDataType.String, 20),
        new JdeField("EDUPMJ", "EDUPMJ", JdeDataType.Numeric),
        new JdeField("EDUPMT", "EDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F749105_0", "Primary Key on EDE74RENA, EDE74RSN, EDE74RRN, EDE74CNO", new[] { "EDE74RENA", "EDE74RSN", "EDE74RRN", "EDE74CNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F749105_2", "Index on EDE74RENA, EDE74RSN, EDE74CNO", new[] { "EDE74RENA", "EDE74RSN", "EDE74CNO" })
    };
}
