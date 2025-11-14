using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F10UI003 - .
/// </summary>
public class F10UI003 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ACEDUS.
        /// </summary>
        public const string ACEDUS = "ACEDUS";

        /// <summary>
        /// ACEDTN.
        /// </summary>
        public const string ACEDTN = "ACEDTN";

        /// <summary>
        /// ACEDBT.
        /// </summary>
        public const string ACEDBT = "ACEDBT";

        /// <summary>
        /// ACDTSE.
        /// </summary>
        public const string ACDTSE = "ACDTSE";

        /// <summary>
        /// ACCO.
        /// </summary>
        public const string ACCO = "ACCO";

        /// <summary>
        /// ACANI.
        /// </summary>
        public const string ACANI = "ACANI";

        /// <summary>
        /// ACDL01.
        /// </summary>
        public const string ACDL01 = "ACDL01";

        /// <summary>
        /// ACLDA.
        /// </summary>
        public const string ACLDA = "ACLDA";

        /// <summary>
        /// ACAID.
        /// </summary>
        public const string ACAID = "ACAID";

        /// <summary>
        /// ACR001.
        /// </summary>
        public const string ACR001 = "ACR001";

        /// <summary>
        /// ACR002.
        /// </summary>
        public const string ACR002 = "ACR002";

        /// <summary>
        /// ACR003.
        /// </summary>
        public const string ACR003 = "ACR003";

        /// <summary>
        /// ACR004.
        /// </summary>
        public const string ACR004 = "ACR004";

        /// <summary>
        /// ACR005.
        /// </summary>
        public const string ACR005 = "ACR005";

        /// <summary>
        /// ACR006.
        /// </summary>
        public const string ACR006 = "ACR006";

        /// <summary>
        /// ACR007.
        /// </summary>
        public const string ACR007 = "ACR007";

        /// <summary>
        /// ACR008.
        /// </summary>
        public const string ACR008 = "ACR008";

        /// <summary>
        /// ACR009.
        /// </summary>
        public const string ACR009 = "ACR009";

        /// <summary>
        /// ACR010.
        /// </summary>
        public const string ACR010 = "ACR010";

        /// <summary>
        /// ACR011.
        /// </summary>
        public const string ACR011 = "ACR011";

        /// <summary>
        /// ACR012.
        /// </summary>
        public const string ACR012 = "ACR012";

        /// <summary>
        /// ACR013.
        /// </summary>
        public const string ACR013 = "ACR013";

        /// <summary>
        /// ACR014.
        /// </summary>
        public const string ACR014 = "ACR014";

        /// <summary>
        /// ACR015.
        /// </summary>
        public const string ACR015 = "ACR015";

        /// <summary>
        /// ACR016.
        /// </summary>
        public const string ACR016 = "ACR016";

        /// <summary>
        /// ACR017.
        /// </summary>
        public const string ACR017 = "ACR017";

        /// <summary>
        /// ACR018.
        /// </summary>
        public const string ACR018 = "ACR018";

        /// <summary>
        /// ACR019.
        /// </summary>
        public const string ACR019 = "ACR019";

        /// <summary>
        /// ACR020.
        /// </summary>
        public const string ACR020 = "ACR020";

        /// <summary>
        /// ACR021.
        /// </summary>
        public const string ACR021 = "ACR021";

        /// <summary>
        /// ACR022.
        /// </summary>
        public const string ACR022 = "ACR022";

        /// <summary>
        /// ACR023.
        /// </summary>
        public const string ACR023 = "ACR023";

        /// <summary>
        /// ACPID.
        /// </summary>
        public const string ACPID = "ACPID";
    }

    /// <inheritdoc />
    public override string TableName => "F10UI003";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ACEDUS", "ACEDUS", JdeDataType.String, 20),
        new JdeField("ACEDTN", "ACEDTN", JdeDataType.String, 44),
        new JdeField("ACEDBT", "ACEDBT", JdeDataType.String, 30),
        new JdeField("ACDTSE", "ACDTSE", JdeDataType.Numeric),
        new JdeField("ACCO", "ACCO", JdeDataType.String, 10),
        new JdeField("ACANI", "ACANI", JdeDataType.String, 58),
        new JdeField("ACDL01", "ACDL01", JdeDataType.String, 60),
        new JdeField("ACLDA", "ACLDA", JdeDataType.String, 2),
        new JdeField("ACAID", "ACAID", JdeDataType.String, 16, true, true),
        new JdeField("ACR001", "ACR001", JdeDataType.String, 6),
        new JdeField("ACR002", "ACR002", JdeDataType.String, 6),
        new JdeField("ACR003", "ACR003", JdeDataType.String, 6),
        new JdeField("ACR004", "ACR004", JdeDataType.String, 6),
        new JdeField("ACR005", "ACR005", JdeDataType.String, 6),
        new JdeField("ACR006", "ACR006", JdeDataType.String, 6),
        new JdeField("ACR007", "ACR007", JdeDataType.String, 6),
        new JdeField("ACR008", "ACR008", JdeDataType.String, 6),
        new JdeField("ACR009", "ACR009", JdeDataType.String, 6),
        new JdeField("ACR010", "ACR010", JdeDataType.String, 6),
        new JdeField("ACR011", "ACR011", JdeDataType.String, 6),
        new JdeField("ACR012", "ACR012", JdeDataType.String, 6),
        new JdeField("ACR013", "ACR013", JdeDataType.String, 6),
        new JdeField("ACR014", "ACR014", JdeDataType.String, 6),
        new JdeField("ACR015", "ACR015", JdeDataType.String, 6),
        new JdeField("ACR016", "ACR016", JdeDataType.String, 6),
        new JdeField("ACR017", "ACR017", JdeDataType.String, 6),
        new JdeField("ACR018", "ACR018", JdeDataType.String, 6),
        new JdeField("ACR019", "ACR019", JdeDataType.String, 6),
        new JdeField("ACR020", "ACR020", JdeDataType.String, 6),
        new JdeField("ACR021", "ACR021", JdeDataType.String, 20),
        new JdeField("ACR022", "ACR022", JdeDataType.String, 20),
        new JdeField("ACR023", "ACR023", JdeDataType.String, 20),
        new JdeField("ACPID", "ACPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F10UI003_0", "Primary Key on ACAID", new[] { "ACAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F10UI003_2", "Index on ACPID", new[] { "ACPID" })
    };
}
