using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F00090 - .
/// </summary>
public class F00090 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// T1SDB.
        /// </summary>
        public const string T1SDB = "T1SDB";

        /// <summary>
        /// T1SFN1.
        /// </summary>
        public const string T1SFN1 = "T1SFN1";

        /// <summary>
        /// T1SFN2.
        /// </summary>
        public const string T1SFN2 = "T1SFN2";

        /// <summary>
        /// T1SFA2.
        /// </summary>
        public const string T1SFA2 = "T1SFA2";

        /// <summary>
        /// T1SFA1.
        /// </summary>
        public const string T1SFA1 = "T1SFA1";

        /// <summary>
        /// T1FKCO.
        /// </summary>
        public const string T1FKCO = "T1FKCO";

        /// <summary>
        /// T1FMC6.
        /// </summary>
        public const string T1FMC6 = "T1FMC6";

        /// <summary>
        /// T1DLKC.
        /// </summary>
        public const string T1DLKC = "T1DLKC";

        /// <summary>
        /// T1DLMC.
        /// </summary>
        public const string T1DLMC = "T1DLMC";

        /// <summary>
        /// T1SBD1.
        /// </summary>
        public const string T1SBD1 = "T1SBD1";

        /// <summary>
        /// T1SBD2.
        /// </summary>
        public const string T1SBD2 = "T1SBD2";

        /// <summary>
        /// T1SBD3.
        /// </summary>
        public const string T1SBD3 = "T1SBD3";

        /// <summary>
        /// T1SBD4.
        /// </summary>
        public const string T1SBD4 = "T1SBD4";

        /// <summary>
        /// T1SAL1.
        /// </summary>
        public const string T1SAL1 = "T1SAL1";

        /// <summary>
        /// T1SAL2.
        /// </summary>
        public const string T1SAL2 = "T1SAL2";

        /// <summary>
        /// T1SAL3.
        /// </summary>
        public const string T1SAL3 = "T1SAL3";

        /// <summary>
        /// T1SAL4.
        /// </summary>
        public const string T1SAL4 = "T1SAL4";

        /// <summary>
        /// T1VFIL.
        /// </summary>
        public const string T1VFIL = "T1VFIL";

        /// <summary>
        /// T1SYN.
        /// </summary>
        public const string T1SYN = "T1SYN";

        /// <summary>
        /// T1FDS.
        /// </summary>
        public const string T1FDS = "T1FDS";

        /// <summary>
        /// T1FILE.
        /// </summary>
        public const string T1FILE = "T1FILE";

        /// <summary>
        /// T1FCNM.
        /// </summary>
        public const string T1FCNM = "T1FCNM";
    }

    /// <inheritdoc />
    public override string TableName => "F00090";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("T1SDB", "T1SDB", JdeDataType.String, 8, true, true),
        new JdeField("T1SFN1", "T1SFN1", JdeDataType.String, 2),
        new JdeField("T1SFN2", "T1SFN2", JdeDataType.String, 2),
        new JdeField("T1SFA2", "T1SFA2", JdeDataType.String, 2),
        new JdeField("T1SFA1", "T1SFA1", JdeDataType.String, 2),
        new JdeField("T1FKCO", "T1FKCO", JdeDataType.String, 2),
        new JdeField("T1FMC6", "T1FMC6", JdeDataType.String, 2),
        new JdeField("T1DLKC", "T1DLKC", JdeDataType.String, 60),
        new JdeField("T1DLMC", "T1DLMC", JdeDataType.String, 60),
        new JdeField("T1SBD1", "T1SBD1", JdeDataType.String, 60),
        new JdeField("T1SBD2", "T1SBD2", JdeDataType.String, 60),
        new JdeField("T1SBD3", "T1SBD3", JdeDataType.String, 60),
        new JdeField("T1SBD4", "T1SBD4", JdeDataType.String, 60),
        new JdeField("T1SAL1", "T1SAL1", JdeDataType.String, 20),
        new JdeField("T1SAL2", "T1SAL2", JdeDataType.String, 20),
        new JdeField("T1SAL3", "T1SAL3", JdeDataType.String, 20),
        new JdeField("T1SAL4", "T1SAL4", JdeDataType.String, 20),
        new JdeField("T1VFIL", "T1VFIL", JdeDataType.String, 16),
        new JdeField("T1SYN", "T1SYN", JdeDataType.String, 2),
        new JdeField("T1FDS", "T1FDS", JdeDataType.String, 2),
        new JdeField("T1FILE", "T1FILE", JdeDataType.String, 20),
        new JdeField("T1FCNM", "T1FCNM", JdeDataType.String, 64)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F00090_0", "Primary Key on T1SDB", new[] { "T1SDB" }, isUnique: true, isPrimaryKey: true)
    };
}
