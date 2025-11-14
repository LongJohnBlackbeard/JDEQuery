using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA000 - .
/// </summary>
public class F90CA000 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// COUKID.
        /// </summary>
        public const string COUKID = "COUKID";

        /// <summary>
        /// COSTDFLT.
        /// </summary>
        public const string COSTDFLT = "COSTDFLT";

        /// <summary>
        /// COGBRL1.
        /// </summary>
        public const string COGBRL1 = "COGBRL1";

        /// <summary>
        /// COGBRL2.
        /// </summary>
        public const string COGBRL2 = "COGBRL2";

        /// <summary>
        /// COGBRL3.
        /// </summary>
        public const string COGBRL3 = "COGBRL3";

        /// <summary>
        /// COGBRL4.
        /// </summary>
        public const string COGBRL4 = "COGBRL4";

        /// <summary>
        /// COCRMURF.
        /// </summary>
        public const string COCRMURF = "COCRMURF";

        /// <summary>
        /// COSODFLT.
        /// </summary>
        public const string COSODFLT = "COSODFLT";

        /// <summary>
        /// COPFS.
        /// </summary>
        public const string COPFS = "COPFS";

        /// <summary>
        /// COPHTP.
        /// </summary>
        public const string COPHTP = "COPHTP";

        /// <summary>
        /// COCALTY.
        /// </summary>
        public const string COCALTY = "COCALTY";

        /// <summary>
        /// COENTDBY.
        /// </summary>
        public const string COENTDBY = "COENTDBY";

        /// <summary>
        /// COEDATE.
        /// </summary>
        public const string COEDATE = "COEDATE";

        /// <summary>
        /// COUSER.
        /// </summary>
        public const string COUSER = "COUSER";

        /// <summary>
        /// COPID.
        /// </summary>
        public const string COPID = "COPID";

        /// <summary>
        /// COVID.
        /// </summary>
        public const string COVID = "COVID";

        /// <summary>
        /// COMKEY.
        /// </summary>
        public const string COMKEY = "COMKEY";

        /// <summary>
        /// COUDTTM.
        /// </summary>
        public const string COUDTTM = "COUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA000";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("COUKID", "COUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("COSTDFLT", "COSTDFLT", JdeDataType.String, 2),
        new JdeField("COGBRL1", "COGBRL1", JdeDataType.Numeric),
        new JdeField("COGBRL2", "COGBRL2", JdeDataType.Numeric),
        new JdeField("COGBRL3", "COGBRL3", JdeDataType.Numeric),
        new JdeField("COGBRL4", "COGBRL4", JdeDataType.Numeric),
        new JdeField("COCRMURF", "COCRMURF", JdeDataType.String, 2),
        new JdeField("COSODFLT", "COSODFLT", JdeDataType.String, 2),
        new JdeField("COPFS", "COPFS", JdeDataType.String, 2),
        new JdeField("COPHTP", "COPHTP", JdeDataType.String, 8),
        new JdeField("COCALTY", "COCALTY", JdeDataType.String, 100),
        new JdeField("COENTDBY", "COENTDBY", JdeDataType.Numeric),
        new JdeField("COEDATE", "COEDATE", JdeDataType.Date),
        new JdeField("COUSER", "COUSER", JdeDataType.String, 20),
        new JdeField("COPID", "COPID", JdeDataType.String, 20),
        new JdeField("COVID", "COVID", JdeDataType.String, 20),
        new JdeField("COMKEY", "COMKEY", JdeDataType.String, 30),
        new JdeField("COUDTTM", "COUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA000_0", "Primary Key on COUKID", new[] { "COUKID" }, isUnique: true, isPrimaryKey: true)
    };
}
